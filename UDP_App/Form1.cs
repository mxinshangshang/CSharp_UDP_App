using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace UDP_App
{
    public partial class Form1 : Form
    {
        IPAddress ip;
        int port;
        private IPEndPoint ipLocalPoint;
        private EndPoint RemotePoint;
        private Socket mySocket;
        private bool RunningFlag = false; 
        public Form1()
        {
            InitializeComponent();
            //tbLocalIP.Text = getIPAddress();
        }

        private string getIPAddress()
        {
            // 获得本机局域网IP地址  
            //IPAddress[] AddressList = Dns.GetHostByName(Dns.GetHostName()).AddressList;
            IPAddress[] AddressList = Dns.GetHostByName(Dns.GetHostName()).AddressList;
            if (AddressList.Length < 1)
            {
                return "";
            }
            return AddressList[2].ToString();
        }

        private int getValidPort(string port)
        {
            int lport;
            //测试端口号是否有效  
            try
            {
                //是否为空  
                if (port == "")
                {
                    throw new ArgumentException(
                        "端口号无效，不能启动DUP");
                }
                lport = System.Convert.ToInt32(port);
            }
            catch (Exception e)
            {
                //ArgumentException,   
                //FormatException,   
                //OverflowException  
                Console.WriteLine("无效的端口号：" + e.ToString());
                this.tbMsg.AppendText("无效的端口号：" + e.ToString() + "\n");
                return -1;
            }
            return lport;
        }


        private IPAddress getValidIP(string ip)
        {
            IPAddress lip = null;
            //测试IP是否有效  
            try
            {
                //是否为空  
                if (!IPAddress.TryParse(ip, out lip))
                {
                    throw new ArgumentException(
                        "IP无效，不能启动DUP");
                }
            }
            catch (Exception e)
            {
                //ArgumentException,   
                //FormatException,   
                //OverflowException  
                Console.WriteLine("无效的IP：" + e.ToString());
                this.tbMsg.AppendText("无效的IP：" + e.ToString() + "\n");
                return null;
            }
            return lip;
        }

        //得到本机IP，设置UDP端口号 
    
        public delegate void MyInvoke(string strRecv);
        private void ReceiveHandle()
        {
            //接收数据处理线程  
            string msg;
            byte[] data = new byte[1024];
            MyInvoke myI = new MyInvoke(UpdateMsgTextBox);
            while (RunningFlag)
            {

                if (mySocket == null || mySocket.Available < 1)
                {
                    Thread.Sleep(200);
                    continue;
                }
                //跨线程调用控件  
                //接收UDP数据报，引用参数RemotePoint获得源地址  
                int rlen = mySocket.ReceiveFrom(data, ref RemotePoint);
                msg = Encoding.Default.GetString(data, 0, rlen);
                tbMsg.BeginInvoke(myI, new object[] { RemotePoint.ToString() + " : " + msg });

            }
        }

        private void UpdateMsgTextBox(string msg)
        {
            //接收数据显示  
            this.tbMsg.AppendText(msg + "\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ip = getValidIP(tbLocalIP.Text);
            port = getValidPort(tbLocalPort.Text);
            ipLocalPoint = new IPEndPoint(ip, port);

            //定义网络类型，数据连接类型和网络协议UDP  
            mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            //绑定网络地址  
            mySocket.Bind(ipLocalPoint);

            //得到客户机IP  
            ip = getValidIP(tbRemoteIP.Text);
            port = getValidPort(tbRemotePort.Text);
            IPEndPoint ipep = new IPEndPoint(ip, port);
            RemotePoint = (EndPoint)(ipep);

            //启动一个新的线程，执行方法this.ReceiveHandle，  
            //以便在一个独立的进程中执行数据接收的操作  

            RunningFlag = true;
            Thread thread = new Thread(new ThreadStart(this.ReceiveHandle));
            thread.Start();  
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            string msg;
            msg = tbSendMsg.Text;
            //发送UDP数据包  
            byte[] data = Encoding.Default.GetBytes(msg);
            mySocket.SendTo(data, data.Length, SocketFlags.None, RemotePoint);
        }
    }
}
