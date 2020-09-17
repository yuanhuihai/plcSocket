using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plcSocket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Socket tcpClient = null;

        private void btn_connect_Click(object sender, EventArgs e)
        {
            tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                tcpClient.Connect(IPAddress.Parse(this.txt_ip.Text), int.Parse(txt_port.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show("连接失败:" + ex.Message);
            }
            MessageBox.Show("连接成功");
        }
    }
}
