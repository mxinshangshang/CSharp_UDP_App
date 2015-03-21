namespace UDP_App
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tbLocalIP = new System.Windows.Forms.TextBox();
            this.tbLocalPort = new System.Windows.Forms.TextBox();
            this.tbRemoteIP = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.tbRemotePort = new System.Windows.Forms.TextBox();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.tbSendMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLocalIP
            // 
            this.tbLocalIP.Location = new System.Drawing.Point(23, 12);
            this.tbLocalIP.Name = "tbLocalIP";
            this.tbLocalIP.Size = new System.Drawing.Size(153, 21);
            this.tbLocalIP.TabIndex = 1;
            // 
            // tbLocalPort
            // 
            this.tbLocalPort.Location = new System.Drawing.Point(182, 12);
            this.tbLocalPort.Name = "tbLocalPort";
            this.tbLocalPort.Size = new System.Drawing.Size(61, 21);
            this.tbLocalPort.TabIndex = 2;
            // 
            // tbRemoteIP
            // 
            this.tbRemoteIP.Location = new System.Drawing.Point(23, 49);
            this.tbRemoteIP.Name = "tbRemoteIP";
            this.tbRemoteIP.Size = new System.Drawing.Size(153, 21);
            this.tbRemoteIP.TabIndex = 3;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(264, 229);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(178, 58);
            this.btSend.TabIndex = 4;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // tbRemotePort
            // 
            this.tbRemotePort.Location = new System.Drawing.Point(182, 49);
            this.tbRemotePort.Name = "tbRemotePort";
            this.tbRemotePort.Size = new System.Drawing.Size(61, 21);
            this.tbRemotePort.TabIndex = 5;
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(23, 87);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMsg.Size = new System.Drawing.Size(220, 200);
            this.tbMsg.TabIndex = 6;
            // 
            // tbSendMsg
            // 
            this.tbSendMsg.Location = new System.Drawing.Point(264, 87);
            this.tbSendMsg.Multiline = true;
            this.tbSendMsg.Name = "tbSendMsg";
            this.tbSendMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSendMsg.Size = new System.Drawing.Size(178, 129);
            this.tbSendMsg.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 299);
            this.Controls.Add(this.tbSendMsg);
            this.Controls.Add(this.tbMsg);
            this.Controls.Add(this.tbRemotePort);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbRemoteIP);
            this.Controls.Add(this.tbLocalPort);
            this.Controls.Add(this.tbLocalIP);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "UDP_Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbLocalIP;
        private System.Windows.Forms.TextBox tbLocalPort;
        private System.Windows.Forms.TextBox tbRemoteIP;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox tbRemotePort;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.TextBox tbSendMsg;
    }
}

