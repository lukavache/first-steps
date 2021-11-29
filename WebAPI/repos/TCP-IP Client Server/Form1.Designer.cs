namespace TCP_IP_Client_Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.Host_txtBox = new System.Windows.Forms.TextBox();
            this.Port_txtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Btb_Stop = new System.Windows.Forms.Button();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // Host_txtBox
            // 
            this.Host_txtBox.Location = new System.Drawing.Point(56, 12);
            this.Host_txtBox.Name = "Host_txtBox";
            this.Host_txtBox.Size = new System.Drawing.Size(100, 20);
            this.Host_txtBox.TabIndex = 1;
            this.Host_txtBox.Text = "127.0.0.1";
            // 
            // Port_txtBox
            // 
            this.Port_txtBox.Location = new System.Drawing.Point(194, 13);
            this.Port_txtBox.Name = "Port_txtBox";
            this.Port_txtBox.Size = new System.Drawing.Size(100, 20);
            this.Port_txtBox.TabIndex = 3;
            this.Port_txtBox.Text = "8910";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(300, 12);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 4;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btb_Stop
            // 
            this.Btb_Stop.Location = new System.Drawing.Point(381, 13);
            this.Btb_Stop.Name = "Btb_Stop";
            this.Btb_Stop.Size = new System.Drawing.Size(75, 23);
            this.Btb_Stop.TabIndex = 5;
            this.Btb_Stop.Text = "Stop";
            this.Btb_Stop.UseVisualStyleBackColor = true;
            this.Btb_Stop.Click += new System.EventHandler(this.Btb_Stop_Click);
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(16, 43);
            this.txt_Status.Multiline = true;
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(455, 165);
            this.txt_Status.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 218);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.Btb_Stop);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Port_txtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Host_txtBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Host_txtBox;
        private System.Windows.Forms.TextBox Port_txtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btb_Stop;
        private System.Windows.Forms.TextBox txt_Status;
    }
}

