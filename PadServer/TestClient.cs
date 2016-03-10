using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace PadServer
{
    public class TestClient
    {
        Socket m_socket;

        public TestClient(int port)
        {
            m_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            m_socket.Connect(new IPEndPoint(IPAddress.Loopback, port));
        }

        public void TestSend(string data)
        {
            byte[] buffer = ASCIIEncoding.ASCII.GetBytes(data);
            m_socket.Send(buffer);
        }
    }
}
