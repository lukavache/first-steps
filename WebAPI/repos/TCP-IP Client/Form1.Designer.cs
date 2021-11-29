namespace TCP_IP_Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.Port_txtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Host_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ToSend = new System.Windows.Forms.TextBox();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.textBox_Chat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(317, 24);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.Btn_Connect.TabIndex = 10;
            this.Btn_Connect.Text = "Connect";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Port_txtBox
            // 
            this.Port_txtBox.Location = new System.Drawing.Point(211, 25);
            this.Port_txtBox.Name = "Port_txtBox";
            this.Port_txtBox.Size = new System.Drawing.Size(100, 20);
            this.Port_txtBox.TabIndex = 9;
            this.Port_txtBox.Text = "8910";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port";
            // 
            // Host_txtBox
            // 
            this.Host_txtBox.Location = new System.Drawing.Point(73, 24);
            this.Host_txtBox.Name = "Host_txtBox";
            this.Host_txtBox.Size = new System.Drawing.Size(100, 20);
            this.Host_txtBox.TabIndex = 7;
            this.Host_txtBox.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Host";
            // 
            // textBox_ToSend
            // 
            this.textBox_ToSend.Location = new System.Drawing.Point(41, 50);
            this.textBox_ToSend.Multiline = true;
            this.textBox_ToSend.Name = "textBox_ToSend";
            this.textBox_ToSend.Size = new System.Drawing.Size(351, 52);
            this.textBox_ToSend.TabIndex = 11;
            // 
            // Btn_Send
            // 
            this.Btn_Send.Location = new System.Drawing.Point(317, 108);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(75, 23);
            this.Btn_Send.TabIndex = 12;
            this.Btn_Send.Text = "Send";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // textBox_Chat
            // 
            this.textBox_Chat.Location = new System.Drawing.Point(41, 137);
            this.textBox_Chat.Multiline = true;
            this.textBox_Chat.Name = "textBox_Chat";
            this.textBox_Chat.Size = new System.Drawing.Size(351, 216);
            this.textBox_Chat.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 370);
            this.Controls.Add(this.textBox_Chat);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.textBox_ToSend);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.Port_txtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Host_txtBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.TextBox Port_txtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Host_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ToSend;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.TextBox textBox_Chat;
    }
}

