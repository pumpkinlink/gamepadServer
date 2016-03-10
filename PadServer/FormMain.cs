using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace PadServer
{
    public partial class FormMain : Form
    {
        private Server m_server;
        private TestClient m_client;

        private string StatusText
        {
            set
            {
                statusText.Text = value;
            }
        }

        #region Virtual Key Code

        private Dictionary<TextBox, VirtualKeyCode> m_keys = new Dictionary<TextBox, VirtualKeyCode>();

        private bool IsValidKey(int keyValue)
        {
            bool isAlpha = keyValue >= 65 && keyValue <= 90;
            bool isNum = keyValue >= 48 && keyValue <= 57;
            bool isArrow = keyValue >= 37 && keyValue <= 40;
            bool isNumpad = keyValue >= 96 && keyValue <= 105;
            bool isBackEnter = keyValue == 13 || keyValue == 8;
            bool isSpace = keyValue == 32;

            return isAlpha || isNum || isArrow || isNumpad || isBackEnter || isSpace;
        }

        private bool SetTextBoxKey(TextBox txt, int keyValue)
        {
            if (IsValidKey(keyValue))
            {
                VirtualKeyCode code = (VirtualKeyCode)keyValue;
                m_keys[txt] = code;
                txt.Text = code.ToString();

                return true;
            }

            return false;
        }

        private bool SetTextBoxKey(TextBox txt, VirtualKeyCode code)
        {
            return SetTextBoxKey(txt, (int)code);
        }

        #endregion

        public FormMain()
        {
            InitializeComponent();

            // set default keys
            SetTextBoxKey(m_diagdown, VirtualKeyCode.DOWN);
            SetTextBoxKey(m_diagup, VirtualKeyCode.UP);
            SetTextBoxKey(m_diagleft, VirtualKeyCode.LEFT);
            SetTextBoxKey(m_diagright, VirtualKeyCode.RIGHT);
            SetTextBoxKey(m_btnx, VirtualKeyCode.VK_X);
            SetTextBoxKey(m_btny, VirtualKeyCode.VK_Y);
            SetTextBoxKey(m_btna, VirtualKeyCode.VK_A);
            SetTextBoxKey(m_btnb, VirtualKeyCode.VK_B);
            SetTextBoxKey(m_btnselect, VirtualKeyCode.BACK);
            SetTextBoxKey(m_btnstart, VirtualKeyCode.RETURN);

            m_server = new Server(9080);
            m_server.DataReceived += DataFromApp;
            m_server.Connected += ClientConnected;
            //m_client = new TestClient(9080);
            //m_client.TestSend("u+");
            //StatusText = m_server.BoundIP;
        }

        private void ClientConnected(System.Net.Sockets.Socket s)
        {
            StatusText = "Conectado em " + s.RemoteEndPoint.ToString();
        }

        #region Received
        private void SimulateInput(char key, char action)
        {
            SendInput send;
            switch (action)
            {
                case '+':
                    send = InputSimulator.SimulateKeyDown;
                    break;
                default:
                    send = InputSimulator.SimulateKeyUp;
                    break;
            }

            switch (key)
            {
                #region Diags
                case 'U':
                    send(m_keys[m_diagup]);
                    break;
                case 'D':
                    send(m_keys[m_diagdown]);
                    break;
                case 'L':
                    send(m_keys[m_diagleft]);
                    break;
                case 'R':
                    send(m_keys[m_diagright]);
                    break;
                #endregion

                #region Buttons
                case 'A':
                    send(m_keys[m_btna]);
                    break;
                case 'B':
                    send(m_keys[m_btnb]);
                    break;
                case 'X':
                    send(m_keys[m_btnx]);
                    break;
                case 'Y':
                    send(m_keys[m_btny]);
                    break;
                #endregion

                #region Select/Start
                case '0':
                    send(m_keys[m_btnselect]);
                    break;
                case 'S':
                    send(m_keys[m_btnstart]);
                    break;
                #endregion
            }
        }
        delegate void SendInput(VirtualKeyCode code);

        private void DataFromApp(string data)
        {
            data = data.ToUpper();
            if (data.Length == 2)
            {
                SimulateInput(data[0], data[1]);
            }
            else
            {
                for (int i = 0; i < data.Length; i += 2)
                    SimulateInput(data[i], data[i + 1]);
            }
            
            //SimulateInput(data[0], data[1]);
            /*data = data.Replace("+", "+,").Replace("-", "-,");

            foreach (string d in data.Split(','))
            {
                if (d.Length ==2)
                    SimulateInput(d[0], d[1]);
            }*/
        }
        #endregion

        #region Controls

        private string GetSpecialKey(int value)
        {
            switch (value)
            {
                case (int)VirtualKeyCode.LEFT:
                    return "LEFT";
                case (int)VirtualKeyCode.UP:
                    return "UP";
                case (int)VirtualKeyCode.RIGHT:
                    return "RIGHT";
                case (int)VirtualKeyCode.DOWN:
                    return "DOWN";
                case (int)VirtualKeyCode.BACK:
                    return "BACK";
                case (int)VirtualKeyCode.RETURN:
                    return "ENTER";
                case(int)VirtualKeyCode.SPACE:
                    return "SPACE";
                default:
                    return null;
            }
        }

        private void DiagKeyDown(object sender, KeyEventArgs e)
        {
            if (SetTextBoxKey((TextBox)sender, e.KeyValue))
            {
                e.Handled = true;
            }
        }

        private void m_btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            //m_client.TestSend("b+");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}