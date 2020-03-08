namespace MailSender
{
    partial class MailSenderForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailSenderForm));
            this.From = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.TextBox();
            this.STMPServer = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.AttachmentButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.openFileDialogAttachment = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // From
            // 
            this.From.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.From.Location = new System.Drawing.Point(12, 12);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(228, 20);
            this.From.TabIndex = 0;
            this.From.Text = "From";
            this.From.Enter += new System.EventHandler(this.From_Enter);
            this.From.Leave += new System.EventHandler(this.From_Leave);
            // 
            // To
            // 
            this.To.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.To.Location = new System.Drawing.Point(12, 38);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(228, 20);
            this.To.TabIndex = 1;
            this.To.Text = "To";
            this.To.Enter += new System.EventHandler(this.To_Enter);
            this.To.Leave += new System.EventHandler(this.To_Leave);
            // 
            // STMPServer
            // 
            this.STMPServer.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.STMPServer.Location = new System.Drawing.Point(12, 64);
            this.STMPServer.Name = "STMPServer";
            this.STMPServer.Size = new System.Drawing.Size(228, 20);
            this.STMPServer.TabIndex = 2;
            this.STMPServer.Text = "smtp.wp.pl";
            this.STMPServer.Enter += new System.EventHandler(this.STMPServer_Enter);
            this.STMPServer.Leave += new System.EventHandler(this.STMPServer_Leave);
            // 
            // Username
            // 
            this.Username.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Username.Location = new System.Drawing.Point(12, 90);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(228, 20);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            this.Username.Enter += new System.EventHandler(this.Username_Enter);
            this.Username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // Password
            // 
            this.Password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Password.Location = new System.Drawing.Point(12, 116);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(228, 20);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // Subject
            // 
            this.Subject.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Subject.Location = new System.Drawing.Point(12, 142);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(228, 20);
            this.Subject.TabIndex = 5;
            this.Subject.Text = "Subject";
            this.Subject.Enter += new System.EventHandler(this.Subjent_Enter);
            this.Subject.Leave += new System.EventHandler(this.Subject_Leave);
            // 
            // Mail
            // 
            this.Mail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Mail.Location = new System.Drawing.Point(12, 168);
            this.Mail.Multiline = true;
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(228, 176);
            this.Mail.TabIndex = 6;
            this.Mail.Text = "Message";
            this.Mail.Enter += new System.EventHandler(this.Message_Enter);
            this.Mail.Leave += new System.EventHandler(this.Message_Leave);
            // 
            // AttachmentButton
            // 
            this.AttachmentButton.Location = new System.Drawing.Point(12, 350);
            this.AttachmentButton.Name = "AttachmentButton";
            this.AttachmentButton.Size = new System.Drawing.Size(75, 23);
            this.AttachmentButton.TabIndex = 7;
            this.AttachmentButton.Text = "Attachment";
            this.AttachmentButton.UseVisualStyleBackColor = true;
            this.AttachmentButton.Click += new System.EventHandler(this.AttachmentButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(165, 350);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 8;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // openFileDialogAttachment
            // 
            this.openFileDialogAttachment.FileName = "openFileDialogAttachment";
            // 
            // MailSenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 388);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.AttachmentButton);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.STMPServer);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MailSenderForm";
            this.Text = "Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox From;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.TextBox STMPServer;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Button AttachmentButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.OpenFileDialog openFileDialogAttachment;
    }
}

