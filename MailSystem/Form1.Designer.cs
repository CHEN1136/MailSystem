namespace MailSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.disconnectbtn = new System.Windows.Forms.Button();
            this.connectbtn = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.readbtn = new System.Windows.Forms.Button();
            this.code = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Delbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.disconnectbtn);
            this.panel1.Controls.Add(this.connectbtn);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.address);
            this.panel1.Location = new System.Drawing.Point(108, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 229);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // disconnectbtn
            // 
            this.disconnectbtn.Location = new System.Drawing.Point(314, 189);
            this.disconnectbtn.Name = "disconnectbtn";
            this.disconnectbtn.Size = new System.Drawing.Size(75, 23);
            this.disconnectbtn.TabIndex = 8;
            this.disconnectbtn.Text = "断开连接";
            this.disconnectbtn.UseVisualStyleBackColor = true;
            this.disconnectbtn.Click += new System.EventHandler(this.disconnectbtn_Click);
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(233, 189);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(75, 23);
            this.connectbtn.TabIndex = 7;
            this.connectbtn.Text = "连接";
            this.connectbtn.UseVisualStyleBackColor = true;
            this.connectbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(147, 189);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 6;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox3.Location = new System.Drawing.Point(185, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 26);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "51280746cj";
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(185, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "chenjia13600@163.com";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 15F);
            this.textBox1.Location = new System.Drawing.Point(185, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "pop.163.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(105, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(89, 72);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.address.Location = new System.Drawing.Point(14, 20);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(149, 20);
            this.address.TabIndex = 0;
            this.address.Text = "POP3服务器地址";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(108, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 100);
            this.panel2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(4, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(385, 88);
            this.listBox1.TabIndex = 0;
            // 
            // readbtn
            // 
            this.readbtn.Font = new System.Drawing.Font("宋体", 15F);
            this.readbtn.Location = new System.Drawing.Point(314, 8);
            this.readbtn.Name = "readbtn";
            this.readbtn.Size = new System.Drawing.Size(75, 41);
            this.readbtn.TabIndex = 7;
            this.readbtn.Text = "读取";
            this.readbtn.UseVisualStyleBackColor = true;
            this.readbtn.Click += new System.EventHandler(this.readbtn_Click);
            // 
            // code
            // 
            this.code.Font = new System.Drawing.Font("宋体", 15F);
            this.code.Location = new System.Drawing.Point(100, 12);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(65, 30);
            this.code.TabIndex = 9;
            this.code.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Delbtn);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.code);
            this.panel3.Controls.Add(this.readbtn);
            this.panel3.Location = new System.Drawing.Point(108, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 52);
            this.panel3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(5, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "邮件编号";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(108, 343);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(392, 96);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "转化";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delbtn
            // 
            this.Delbtn.Font = new System.Drawing.Font("宋体", 15F);
            this.Delbtn.Location = new System.Drawing.Point(233, 8);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(75, 41);
            this.Delbtn.TabIndex = 10;
            this.Delbtn.Text = "删除";
            this.Delbtn.UseVisualStyleBackColor = true;
            this.Delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button disconnectbtn;
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button readbtn;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delbtn;
    }
}

