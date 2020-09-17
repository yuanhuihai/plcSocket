namespace plcSocket
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listInfo = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.txt_port);
            this.groupBox1.Controls.Add(this.txt_ip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 489);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "网络设置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "远程主机地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "远程主机端口";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(40, 124);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(304, 42);
            this.txt_ip.TabIndex = 1;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(40, 262);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(304, 42);
            this.txt_port.TabIndex = 3;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(40, 361);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(186, 67);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "连接";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(41, 579);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1292, 340);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PLC IP地址";
            // 
            // listInfo
            // 
            this.listInfo.FormattingEnabled = true;
            this.listInfo.ItemHeight = 30;
            this.listInfo.Location = new System.Drawing.Point(715, 51);
            this.listInfo.Name = "listInfo";
            this.listInfo.Size = new System.Drawing.Size(598, 484);
            this.listInfo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 931);
            this.Controls.Add(this.listInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "基于Socket实现和PLC通讯";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listInfo;
    }
}

