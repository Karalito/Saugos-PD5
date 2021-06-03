
namespace Server
{
    partial class Server
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
            this.CheckMessageBtn = new System.Windows.Forms.Button();
            this.statusTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.messageTxt = new System.Windows.Forms.RichTextBox();
            this.StartServerBtn = new System.Windows.Forms.Button();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ipAddrTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StopServerBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckMessageBtn
            // 
            this.CheckMessageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckMessageBtn.Location = new System.Drawing.Point(284, 285);
            this.CheckMessageBtn.Name = "CheckMessageBtn";
            this.CheckMessageBtn.Size = new System.Drawing.Size(109, 33);
            this.CheckMessageBtn.TabIndex = 19;
            this.CheckMessageBtn.Text = "Check";
            this.CheckMessageBtn.UseVisualStyleBackColor = true;
            this.CheckMessageBtn.Click += new System.EventHandler(this.CheckMessageBtn_Click);
            // 
            // statusTxt
            // 
            this.statusTxt.AutoSize = true;
            this.statusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTxt.Location = new System.Drawing.Point(122, 290);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(67, 20);
            this.statusTxt.TabIndex = 18;
            this.statusTxt.Text = "stopped";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Server Status:";
            // 
            // messageTxt
            // 
            this.messageTxt.Location = new System.Drawing.Point(17, 21);
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(376, 256);
            this.messageTxt.TabIndex = 15;
            this.messageTxt.Text = "";
            // 
            // StartServerBtn
            // 
            this.StartServerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartServerBtn.Location = new System.Drawing.Point(284, 18);
            this.StartServerBtn.Name = "StartServerBtn";
            this.StartServerBtn.Size = new System.Drawing.Size(109, 32);
            this.StartServerBtn.TabIndex = 14;
            this.StartServerBtn.Text = "Start";
            this.StartServerBtn.UseVisualStyleBackColor = true;
            this.StartServerBtn.Click += new System.EventHandler(this.StartServerBtn_Click);
            // 
            // portTxt
            // 
            this.portTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portTxt.Location = new System.Drawing.Point(147, 58);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(117, 22);
            this.portTxt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Port:";
            // 
            // ipAddrTxt
            // 
            this.ipAddrTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddrTxt.Location = new System.Drawing.Point(147, 30);
            this.ipAddrTxt.Name = "ipAddrTxt";
            this.ipAddrTxt.Size = new System.Drawing.Size(117, 22);
            this.ipAddrTxt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Host Ip Address:";
            // 
            // StopServerBtn
            // 
            this.StopServerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopServerBtn.Location = new System.Drawing.Point(284, 56);
            this.StopServerBtn.Name = "StopServerBtn";
            this.StopServerBtn.Size = new System.Drawing.Size(109, 33);
            this.StopServerBtn.TabIndex = 20;
            this.StopServerBtn.Text = "Stop";
            this.StopServerBtn.UseVisualStyleBackColor = true;
            this.StopServerBtn.Click += new System.EventHandler(this.StopServerBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.portTxt);
            this.groupBox1.Controls.Add(this.StopServerBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ipAddrTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StartServerBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Properties";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.messageTxt);
            this.groupBox2.Controls.Add(this.CheckMessageBtn);
            this.groupBox2.Controls.Add(this.statusTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 324);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Server";
            this.Text = "Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CheckMessageBtn;
        private System.Windows.Forms.Label statusTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox messageTxt;
        private System.Windows.Forms.Button StartServerBtn;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipAddrTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StopServerBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

