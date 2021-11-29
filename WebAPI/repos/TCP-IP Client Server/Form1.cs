using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_IP_Client_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;//enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txt_Status.Invoke((MethodInvoker)delegate ()
            {
                txt_Status.Text += e.MessageString;
                e.ReplyLine(string.Format("you said: {0}", e.MessageString));
            });
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            txt_Status.Text += "Server Starting...";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(Host_txtBox.Text);
            server.Start(ip, Convert.ToInt32(Port_txtBox.Text));
        }

        private void Btb_Stop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted) server.Stop();
        }
    }
}
