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

namespace TCP_IP_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            
            client.DataReceived += Client_DataReceived;
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            client.Connect(Host_txtBox.Text, Convert.ToInt32(Port_txtBox.Text));
            Btn_Connect.Enabled = false;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            textBox_Chat.Invoke((MethodInvoker)delegate ()
            {
                textBox_Chat.Text += e.MessageString;
            });
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(textBox_ToSend.Text, TimeSpan.FromSeconds(3));
        }
    }
}
