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
using Client.CustomControl;
using System.Threading;
namespace Client
{
    public partial class MainForm : Form
    {
        string serverip;
        string name;
        List<Tiles> FriendListTiles = new List<Tiles>();
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(string svip,string username)
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            serverip = svip;
            name = username;

            //SocketPacket reqfriendpacket = new SocketPacket(PacketType.REQFRIEND, getlocalIP(), serverip, 52052, 52054);
            //DataTranferer.Send(serverip, 52054, reqfriendpacket);
            //ThreadStart receivethread = new ThreadStart(ReceiveFromServer);
            //Thread thread1 = new Thread(receivethread);
            //thread1.IsBackground = true;
            //thread1.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SocketPacket reqfriendpacket = new SocketPacket(PacketType.REQFRIEND, getlocalIP(), serverip, 52052, 52054);
            DataTranferer.Send(serverip, 52054, reqfriendpacket);
            ThreadStart receivethread = new ThreadStart(ReceiveFromServer);
            Thread thread1 = new Thread(receivethread);
            thread1.IsBackground = true;
            thread1.Start();
        }

        private void ptbClose_MouseEnter(object sender, EventArgs e)
        {
            this.ptbClose.BackColor = Color.FromArgb(207, 207, 207);
        }

        private void ptbClose_MouseLeave(object sender, EventArgs e)
        {
            this.ptbClose.BackColor = Color.Transparent;
        }

        private void ptbClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void ptbMinimize_MouseEnter(object sender, EventArgs e)
        {
            this.ptbMinimize.BackColor = Color.FromArgb(207, 207, 207);
        }

        private void ptbMinimize_MouseLeave(object sender, EventArgs e)
        {
            this.ptbMinimize.BackColor = Color.Transparent;
        }

        private void ptbMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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
        public void GetFriendList(string st)
        {
            FriendListTiles.Clear();
            string[] separator = { "\n" };
            string[] subst = st.Split(separator,StringSplitOptions.RemoveEmptyEntries);
            int FriendCount = Convert.ToInt32(subst[0]);
            for(int i = 0; i < FriendCount; ++i)
            {
                string[] subsubst = subst[i+1].Split(':');
                //if (subsubst[1] == name)
                    //continue;
                Tiles friendtiles = new Tiles();
                friendtiles.TilesName.Text = subsubst[0];
                friendtiles.TilesIP = subsubst[1];
                friendtiles.Location = new Point(253 + 187*(i%3),40 + 187*(i/3));
                friendtiles.Size = new Size(147, 147);
                FriendListTiles.Add(friendtiles);
                //this.Controls.Add(FriendListTiles[i]);
                this.Invoke((MethodInvoker)delegate
                {
                    this.Controls.Add(FriendListTiles[i]);
                });
            }
        }
        private void ReceiveFromServer()
        {

            UdpClient receiver = new UdpClient(52053);
            while (true)
            {
                IPEndPoint serveriPEnd = new IPEndPoint(IPAddress.Parse(serverip), 52051);
                byte[] data = receiver.Receive(ref serveriPEnd);
                SocketPacket returnpacket = SocketPacket.DeSerializedItem(data);
                MessageBox.Show(returnpacket.Message);
                switch(returnpacket.packetType)
                {
                    case PacketType.REQFRIEND:
                        GetFriendList(returnpacket.Message);
                        break;
                }
            }
                
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SocketPacket disconnect = new SocketPacket(PacketType.DISCON, getlocalIP(), serverip, 52052, 52054);
            DataTranferer.Send(serverip, 52052, disconnect);
        }
    }
}
