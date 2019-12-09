using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Sockets;
using System.Net;
using Packet;
using Networking;
namespace Client
{
    public partial class LoginForm : Form
    {
        TcpClient client;
        string localIP = getlocalIP();
        public LoginForm()
        {
            InitializeComponent();
            this.button1.Left = (this.Width - this.button1.Width) / 2;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ptbClose.BackColor = Color.FromArgb(118, 22, 22);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ptbClose.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            this.Close();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;

            SocketPacket packet = new SocketPacket(PacketType.REQCON, localIP, txbserverip.Text, 52052, 52054,txbName.Text);
            SocketPacket returnpacket = DataTranferer.SendAndReceive(txbserverip.Text, 52054, packet);
            if (returnpacket.Message == "OK")
            {
                MainForm main = new MainForm(txbserverip.Text,txbName.Text);
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(returnpacket.Message);
            }
        }
        public static string getlocalIP()
        {
            string localIP;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            return localIP;
        }
    }
}
