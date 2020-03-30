using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Text.RegularExpressions;

namespace MailSystem
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        #region 全局变量

        private TcpClient Server;
        private static NetworkStream StrmWtr;
        private static StreamReader StrmRdr;
        private static String cmdData;
        private static byte[] szData;
        private const String CRLF = "\r\n";
        private static string Asender;
        public static byte[] getSZdata
        {
            get
            {
                return szData;

            }
        }

        public static NetworkStream getStrmWtr
        {
            get
            {
                return StrmWtr;

            }
        }

        public static StreamReader getStrmRdr
        {
            get
            {
                return StrmRdr;

            }
        }

       public static string getsender {
            get {
                return Asender;
            }
        }
        public static String getcmdData
        {
            get
            {
                return cmdData;
            }
        }

        #endregion

        #region 全局函数
        private String getSatus()
        {
            String ret = StrmRdr.ReadLine();

            return ret;
        }

        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            Cursor cr = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            Server = new TcpClient("pop." + SubstringSingle(this.textBox2.Text, "@", "com") + "com",110);

            try
            {
                StrmWtr = Server.GetStream();
                StrmRdr = new StreamReader(Server.GetStream());
                this.getSatus();

                string ret;

                //Login
                cmdData = "USER " + this.textBox2.Text + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                cmdData = "PASS " + this.textBox3.Text + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                ret = this.getSatus();
                if (ret[0] == '-') throw new InvalidOperationException("用户名密码错误");

                //Get Email's Info
                cmdData = "STAT" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                this.Hide();
                Form1 pf = new Form1();
                pf.Show();

            }
            catch (InvalidOperationException err)
            {
                MessageBox.Show("用户名密码错误");
            }
            finally
            {
                Cursor.Current = cr;
            }
        }

        //匹配字符串
        public string SubstringSingle(string source, string startStr, string endStr)
        {
            Regex rg = new Regex("(?<=(" + startStr + "))[.\\s\\S]*?(?=(" + endStr + "))", RegexOptions.Multiline | RegexOptions.Singleline);
            return rg.Match(source).Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor cr = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            string protocol = "smtp." + SubstringSingle(this.textBox2.Text, "@", "com") + "com";
            Asender = this.textBox2.Text;
            Server = new TcpClient(protocol, 25);
            try
            {
                StrmWtr = Server.GetStream();
                StrmRdr = new StreamReader(Server.GetStream());
                this.getSatus();

                //Login
                cmdData = "HELO " + protocol + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                cmdData = "AUTH LOGIN" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                cmdData = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(this.textBox2.Text)) + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                cmdData = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(this.textBox3.Text)) + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                
                Form2 sf = new Form2();
                
                sf.Show();
                this.Hide();

            }
            catch (InvalidOperationException err)
            {
                MessageBox.Show("ERROR: " + err.ToString());
            }
            finally
            {
                Cursor.Current = cr;
            }
        }
    }
}
