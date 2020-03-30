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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 全局变量

        private TcpClient Server;
        private NetworkStream StrmWtr = Login.getStrmWtr;
        private StreamReader StrmRdr = Login.getStrmRdr;
        private String cmdData;
        private byte[] szData = Login.getSZdata;
        private const String CRLF = "\r\n";

        #endregion

        #region 全局函数
        private String getSatus()
        {
            String ret = StrmRdr.ReadLine();
            this.listBox1.Items.Add(ret);
            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
            return ret;
        }

        #endregion




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void disconnectbtn_Click(object sender, EventArgs e)
        {
            Cursor cr = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            //Logout
            cmdData = "QUIT" + CRLF;
            szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
            StrmWtr.Write(szData, 0, szData.Length);
            this.getSatus();

            StrmWtr.Close();
            StrmRdr.Close();
            

            Cursor.Current = cr;
            Login lf = new Login();
            lf.Show();
            this.Hide();


        }

        private void readbtn_Click(object sender, EventArgs e)
        {
            Cursor cr = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            string szTemp;
            this.richTextBox1.Clear();

            try
            {
                cmdData = "RETR " + this.code.Text + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                szTemp = this.getSatus();
                


                if (szTemp[0] != '-')
                {
                    string content = "";
                    while (szTemp != ".")
                    {
                        content += szTemp + "\r\n";
                        szTemp = StrmRdr.ReadLine();
                       
                    }
                    Console.WriteLine(content);
                    
                    string from = SubstringSingle(content, "from:", "\r\n");
                    string to = SubstringSingle(content, "to:", "\r\n");
                    string subject = SubstringSingle(content, "subject:", "\r\n");
                    string date = SubstringSingle(content, "Date:", "\r\n");
                    string message = SubstringSingle(content, "\r\n\r\n", "\r\n");
                    this.richTextBox1.Text = "subject:" + subject + "\r\n"+
                                             "from:" + from + "\r\n"+
                                            "to:" + to + "\r\n"+
                                            "date:" + date + "\r\n" +
                                            "正文:" + message + "\r\n";
                }
            }
            catch (InvalidOperationException err)
            {
                this.listBox1.Items.Add("ERROR: " + err.Message.ToString());

            }
        }

        //匹配字符串
        public string SubstringSingle(string source, string startStr, string endStr)
        {
            Regex rg = new Regex("(?<=(" + startStr + "))[.\\s\\S]*?(?=(" + endStr + "))", RegexOptions.Multiline | RegexOptions.Singleline);
            return rg.Match(source).Value;
        }
 





        private void Delbtn_Click(object sender, EventArgs e)
        {

            //DELE
            try
            {
                cmdData = "DELE " + this.code.Text + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                //StrmWtr.Write(szData, 0, szData.Length);

                cmdData = "QUIT" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                StrmWtr.Close();
                StrmRdr.Close();

                

            }
            catch (InvalidOperationException err)
            {
                this.listBox1.Items.Add("ERROR: " + err.Message.ToString());

            }


            this.richTextBox1.Clear();

        }

    }
}
