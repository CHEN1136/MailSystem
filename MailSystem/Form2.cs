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
        private NetworkStream StrmWtr = Login.getStrmWtr;
        private StreamReader StrmRdr = Login.getStrmRdr;
        private String cmdData = Login.getcmdData;
        private byte[] szData = Login.getSZdata;
        private const String CRLF = "\r\n";
        private string Sender = Login.getsender;
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

            Cursor.Current = cr;
            
            Login lf = new Login();
            lf.Show();
            this.Hide();
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Send Email
                cmdData = "MAIL FROM: <" + Sender + ">" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.GetSatus();

                //抄送自己的邮箱以防被当成垃圾邮件
                cmdData = "RCPT TO: <" + Sender + ">" + CRLF;
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

                cmdData = "from: " + Sender + CRLF
                            + "to: " + this.textBox5.Text + CRLF
                            + "subject: " + this.textBox6.Text + CRLF + CRLF
                            + this.richTextBox1.Text + CRLF + "." + CRLF;
                szData = System.Text.Encoding.UTF8.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.GetSatus();

            }
            catch (InvalidOperationException err)
            {
                MessageBox.Show(Sender);

                this.listBox1.Items.Add("ERROR: " + err.ToString());
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
