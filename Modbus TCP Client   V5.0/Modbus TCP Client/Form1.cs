using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Text;
using System.Xml;


namespace Modbus_TCP_Client
{
    public partial class Form1 : Form
    {
        public Socket newclient;
        public bool Connected;
        public Thread myThread;
        static string ipadd;
        static int port;
        static int isecond;
        public delegate void MyInvoke(string str);
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }






        public void Connect()
        {
            byte[] data = new byte[1024];

          
            XmlDocument doc = new XmlDocument();
            
            doc.Load("XMLFile1.xml");
            
            XmlElement root = doc.DocumentElement;
            XmlNodeList xnl = root.ChildNodes;
            ipadd = xnl.Item(0).InnerText;
            port =Convert.ToInt16( xnl.Item(1).InnerText);
            isecond= Convert.ToInt16(xnl.Item(2).InnerText);


            //创建一个套接字 

            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ipadd), port);
            newclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            //将套接字与远程服务器地址相连
            try
            {
                newclient.Connect(ie);
                connect.Enabled = false;//使连接按钮变成虚的，无法点击
                Connected = true;

            }
            catch (SocketException e)
            {
                MessageBox.Show("连接服务器失败  " + e.Message);
                return;
            }

            ThreadStart myThreaddelegate = new ThreadStart(ReceiveMsg);
            myThread = new Thread(myThreaddelegate);
            myThread.Start();
            timersend.Enabled = true;



        }

        private void connect_Click_1(object sender, EventArgs e)
        {
            Connect();
        }

       private void timersend_Tick(object sender, EventArgs e)
        {
            /*  int isecond = 5000;//以毫秒为单位
              timersend.Interval = isecond;//5秒触发一次
              byte[] data = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x03, 0x00, 0x6C, 0x00, 0x03 };
              //   byte[] data = new byte[] { 0x00, 0x0f, 0x00, 0x00, 0x00, 0x06, 0x01, 0x04, 0x00, 0x00, 0x00, 0x01 };
              newclient.Send(data); */
            XmlDocument doc = new XmlDocument();
            doc.Load("XMLFile1.xml");

            XmlElement root = doc.DocumentElement;
            XmlNodeList xnl = root.ChildNodes;

            isecond = Convert.ToInt16(xnl.Item(2).InnerText);

            //  int isecond = 5000;//以毫秒为单位
             timersend.Interval = isecond;//5秒触发一次
            byte[] data = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x03, 0x00, 0x6C, 0x00, 0x03 };
  //   byte[] data = new byte[] { 0x00, 0x0f, 0x00, 0x00, 0x00, 0x06, 0x01, 0x04, 0x00, 0x00, 0x00, 0x01 };
             newclient.Send(data); 
        }

        public void ReceiveMsg()
        {
            while (true)
            {
                byte[] data = new byte[1024];
                newclient.Receive(data);






                int length = data[5];
                Byte[] datashow = new byte[length + 6];
                Byte[] info = new byte[2];
                info[0] = data[9];
                info[1] = data[10];
                for (int i = 0; i <= length + 5; i++)
                    datashow[i] = data[i];
                string stringdata = BitConverter.ToString(datashow);//把数组转换成16进制字符串
                string stringinfo = BitConverter.ToString(info);

              //  if (data[7] == 0x03) { showMsg03(stringdata + "\r\n"); };
                if (data[7] == 0x03) { showMsg03(stringinfo + "\r\n"); };

            }
        }

      

        private void send03_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x03, 0x00, 0x6C, 0x00, 0x03 };
            newclient.Send(data);
        }

        public void showMsg03(string msg)
        {

            //在线程里以安全方式调用控件
            if (receive0x03.InvokeRequired)
            {
                MyInvoke _myinvoke = new MyInvoke(showMsg03);
                receive0x03.Invoke(_myinvoke, new object[] { msg });
            }
            else
            {
                receive0x03.AppendText(msg);
            }

        }

     
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void receive0x01_TextChanged(object sender, EventArgs e)
        {

        }

        private void receive0x03_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void serverIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[] { 0x01, 0x03, 0x00, 0x01, 0x00, 0x01, 0xD5, 0xCA};
            newclient.Send(data);
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inforeceive_TextChanged(object sender, EventArgs e)
        {

        }
    }
}