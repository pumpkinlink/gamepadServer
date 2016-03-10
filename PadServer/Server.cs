using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using WindowsInput;
using System.Threading;

namespace PadServer
{
    public delegate void DataReceivedEventHandler(string data);
    public delegate void ConnectedEventHandler(Socket s);

    public class Server
    {
        #region Fields

        // Handler & Callback
        public DataReceivedEventHandler DataReceived;
        public ConnectedEventHandler Connected;
        // Tamanho maximo do buffer
        private const int BUFFER_SIZE = 8;
        // Socket durr
        private Socket m_socket;
        // Buffer de bytes a serem recebidos
        private byte[] m_buffer;

        #endregion

        #region Async Sockets

        public void OnConnect(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            m_socket = socket.EndAccept(ar);
            BeginReceive();
            Connected(m_socket);
        }

        public void OnReceive(IAsyncResult ar)
        {
            m_socket = (Socket)ar.AsyncState;

            // Tamanho da mensagem recebida
            int size = m_socket.EndReceive(ar);
            // Converte os bytes recebidos em string
            string data = ASCIIEncoding.ASCII.GetString(m_buffer, 0, size);
            DataReceived(data);
            // Continua recebendo as proximas mensagens
            BeginReceive();
        }

        private void BeginReceive()
        {
            m_socket.BeginReceive(m_buffer, 0, BUFFER_SIZE, SocketFlags.None, OnReceive, m_socket);
        }

        #endregion

        #region Constructor

        public Server(int port)
        {
            m_buffer = new byte[BUFFER_SIZE];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, port);

            m_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            m_socket.NoDelay = true;
            m_socket.Bind(ipep);
            m_socket.Listen(0);
            m_socket.BeginAccept(OnConnect, m_socket);
        }

        #endregion
    }
}
