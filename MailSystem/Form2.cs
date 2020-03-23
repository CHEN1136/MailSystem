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

namespace MailSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        #region 全局变量

        private TcpClient Server;
        private NetworkStream StrmWtr;
        private StreamReader StrmRdr;
        private String cmdData;
        private byte[] szData;
        private const String CRLF = "\r\n";

        #endregion

        #region 全局函数
        private String GetSatus()
        {
            String ret = StrmRdr.ReadLine();
            this.listBox1.Items.Add(ret);
            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
            return ret;
        }

        #endregion

        private void conbtn_Click(object sender, EventArgs e)
        {
            Cursor cr = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Server = new TcpClient(this.textBox1.Text, 25);
            this.listBox1.Items.Clear();
            try
            {
                StrmWtr = Server.GetStream();
                StrmRdr = new StreamReader(Server.GetStream());
                this.GetSatus();

                //Login
                cmdData = "HELO " + this.textBox1.Text + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.GetSatus();

                cmdData = "AUTH LOGIN" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.GetSatus();

                cmdData = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(this.textBox4.Text)) + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.GetSatus();

                cmdData = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(this.textBox2.Text)) + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.GetSatus();


                this.conbtn.Enabled = false;
                this.disconbtn.Enabled = true;

            }
            catch (InvalidOperationException err)
            {
                this.listBox1.Items.Add("ERROR: " + err.ToString());
            }
            finally
            {
                Cursor.Current = cr;
            }
        }

        private void disconbtn_Click(object sender, EventArgs e)
        {
            Cursor cr = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            //Logout
            cmdData = "QUIT" + CRLF;
            szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
            StrmWtr.Write(szData, 0, szData.Length);
            this.GetSatus();

            StrmWtr.Close();
            StrmRdr.Close();


            this.conbtn.Enabled = true;
            this.disconbtn.Enabled = false;

            Cursor.Current = cr;

        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Send Email
                cmdData = "MAIL FROM: <" + this.textBox3.Text + ">" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.GetSatus();

                //抄送自己的邮箱以防被当成垃圾邮件
                cmdData = "RCPT TO: <" + this.textBox3.Text + ">" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.GetSatus();
                

                cmdData = "RCPT TO: <" + this.textBox5.Text + ">" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.GetSatus();

                

                cmdData = "DATA" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.GetSatus();

                cmdData = "from: " + this.textBox3.Text + CRLF
                            + "to: " + this.textBox5.Text + CRLF
                            + "subject: " + this.textBox6.Text + CRLF + CRLF
                            + this.richTextBox1.Text + CRLF + "." + CRLF;
                szData = System.Text.Encoding.UTF8.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.GetSatus();

            }
            catch (InvalidOperationException err)
            {
                this.listBox1.Items.Add("ERROR: " + err.ToString());
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
