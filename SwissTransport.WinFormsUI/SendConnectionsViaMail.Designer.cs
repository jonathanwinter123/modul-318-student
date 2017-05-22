namespace SwissTransport.WinFormsUI
{
    partial class sendConnectionsViaMailForm
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
            this.txtFromSmtpServer = new System.Windows.Forms.TextBox();
            this.txtSenderMail = new System.Windows.Forms.TextBox();
            this.txtFromMailCredentialPassword = new System.Windows.Forms.TextBox();
            this.txtFromMailCredentialUsername = new System.Windows.Forms.TextBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.txtFromSmtpPort = new System.Windows.Forms.NumericUpDown();
            this.lblFromSmtpServer = new System.Windows.Forms.Label();
            this.lblFromSmtpPort = new System.Windows.Forms.Label();
            this.lblFromMailCredentialUsername = new System.Windows.Forms.Label();
            this.lblFromMailCredentialPassword = new System.Windows.Forms.Label();
            this.lblSenderMail = new System.Windows.Forms.Label();
            this.lblRecipientMail = new System.Windows.Forms.Label();
            this.txtRecipientMail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromSmtpPort)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFromSmtpServer
            // 
            this.txtFromSmtpServer.Location = new System.Drawing.Point(12, 27);
            this.txtFromSmtpServer.Name = "txtFromSmtpServer";
            this.txtFromSmtpServer.Size = new System.Drawing.Size(100, 20);
            this.txtFromSmtpServer.TabIndex = 0;
            // 
            // txtSenderMail
            // 
            this.txtSenderMail.Location = new System.Drawing.Point(12, 113);
            this.txtSenderMail.Name = "txtSenderMail";
            this.txtSenderMail.Size = new System.Drawing.Size(100, 20);
            this.txtSenderMail.TabIndex = 1;
            // 
            // txtFromMailCredentialPassword
            // 
            this.txtFromMailCredentialPassword.Location = new System.Drawing.Point(152, 70);
            this.txtFromMailCredentialPassword.Name = "txtFromMailCredentialPassword";
            this.txtFromMailCredentialPassword.Size = new System.Drawing.Size(100, 20);
            this.txtFromMailCredentialPassword.TabIndex = 2;
            // 
            // txtFromMailCredentialUsername
            // 
            this.txtFromMailCredentialUsername.Location = new System.Drawing.Point(12, 70);
            this.txtFromMailCredentialUsername.Name = "txtFromMailCredentialUsername";
            this.txtFromMailCredentialUsername.Size = new System.Drawing.Size(100, 20);
            this.txtFromMailCredentialUsername.TabIndex = 3;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(197, 226);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(75, 23);
            this.btnSendMail.TabIndex = 4;
            this.btnSendMail.Text = "Send";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // txtFromSmtpPort
            // 
            this.txtFromSmtpPort.Location = new System.Drawing.Point(152, 27);
            this.txtFromSmtpPort.Name = "txtFromSmtpPort";
            this.txtFromSmtpPort.Size = new System.Drawing.Size(100, 20);
            this.txtFromSmtpPort.TabIndex = 5;
            // 
            // lblFromSmtpServer
            // 
            this.lblFromSmtpServer.AutoSize = true;
            this.lblFromSmtpServer.Location = new System.Drawing.Point(12, 9);
            this.lblFromSmtpServer.Name = "lblFromSmtpServer";
            this.lblFromSmtpServer.Size = new System.Drawing.Size(71, 13);
            this.lblFromSmtpServer.TabIndex = 6;
            this.lblFromSmtpServer.Text = "SMTP Server";
            // 
            // lblFromSmtpPort
            // 
            this.lblFromSmtpPort.AutoSize = true;
            this.lblFromSmtpPort.Location = new System.Drawing.Point(152, 8);
            this.lblFromSmtpPort.Name = "lblFromSmtpPort";
            this.lblFromSmtpPort.Size = new System.Drawing.Size(59, 13);
            this.lblFromSmtpPort.TabIndex = 7;
            this.lblFromSmtpPort.Text = "SMTP Port";
            // 
            // lblFromMailCredentialUsername
            // 
            this.lblFromMailCredentialUsername.AutoSize = true;
            this.lblFromMailCredentialUsername.Location = new System.Drawing.Point(12, 54);
            this.lblFromMailCredentialUsername.Name = "lblFromMailCredentialUsername";
            this.lblFromMailCredentialUsername.Size = new System.Drawing.Size(55, 13);
            this.lblFromMailCredentialUsername.TabIndex = 8;
            this.lblFromMailCredentialUsername.Text = "Username";
            // 
            // lblFromMailCredentialPassword
            // 
            this.lblFromMailCredentialPassword.AutoSize = true;
            this.lblFromMailCredentialPassword.Location = new System.Drawing.Point(155, 54);
            this.lblFromMailCredentialPassword.Name = "lblFromMailCredentialPassword";
            this.lblFromMailCredentialPassword.Size = new System.Drawing.Size(50, 13);
            this.lblFromMailCredentialPassword.TabIndex = 9;
            this.lblFromMailCredentialPassword.Text = "Passwort";
            // 
            // lblSenderMail
            // 
            this.lblSenderMail.AutoSize = true;
            this.lblSenderMail.Location = new System.Drawing.Point(15, 97);
            this.lblSenderMail.Name = "lblSenderMail";
            this.lblSenderMail.Size = new System.Drawing.Size(52, 13);
            this.lblSenderMail.TabIndex = 10;
            this.lblSenderMail.Text = "Absender";
            // 
            // lblRecipientMail
            // 
            this.lblRecipientMail.AutoSize = true;
            this.lblRecipientMail.Location = new System.Drawing.Point(155, 97);
            this.lblRecipientMail.Name = "lblRecipientMail";
            this.lblRecipientMail.Size = new System.Drawing.Size(58, 13);
            this.lblRecipientMail.TabIndex = 11;
            this.lblRecipientMail.Text = "Empfänger";
            // 
            // txtRecipientMail
            // 
            this.txtRecipientMail.Location = new System.Drawing.Point(152, 113);
            this.txtRecipientMail.Name = "txtRecipientMail";
            this.txtRecipientMail.Size = new System.Drawing.Size(100, 20);
            this.txtRecipientMail.TabIndex = 12;
            // 
            // sendConnectionsViaMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtRecipientMail);
            this.Controls.Add(this.lblRecipientMail);
            this.Controls.Add(this.lblSenderMail);
            this.Controls.Add(this.lblFromMailCredentialPassword);
            this.Controls.Add(this.lblFromMailCredentialUsername);
            this.Controls.Add(this.lblFromSmtpPort);
            this.Controls.Add(this.lblFromSmtpServer);
            this.Controls.Add(this.txtFromSmtpPort);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.txtFromMailCredentialUsername);
            this.Controls.Add(this.txtFromMailCredentialPassword);
            this.Controls.Add(this.txtSenderMail);
            this.Controls.Add(this.txtFromSmtpServer);
            this.Name = "sendConnectionsViaMailForm";
            this.Text = "Sende Verbindungen als Mail";
            ((System.ComponentModel.ISupportInitialize)(this.txtFromSmtpPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFromSmtpServer;
        private System.Windows.Forms.TextBox txtSenderMail;
        private System.Windows.Forms.TextBox txtFromMailCredentialPassword;
        private System.Windows.Forms.TextBox txtFromMailCredentialUsername;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.NumericUpDown txtFromSmtpPort;
        private System.Windows.Forms.Label lblFromSmtpServer;
        private System.Windows.Forms.Label lblFromSmtpPort;
        private System.Windows.Forms.Label lblFromMailCredentialUsername;
        private System.Windows.Forms.Label lblFromMailCredentialPassword;
        private System.Windows.Forms.Label lblSenderMail;
        private System.Windows.Forms.Label lblRecipientMail;
        private System.Windows.Forms.TextBox txtRecipientMail;
    }
}