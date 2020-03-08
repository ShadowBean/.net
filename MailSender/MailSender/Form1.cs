using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace MailSender
{
    public partial class MailSenderForm : Form
    {
        string file = null;

        public MailSenderForm()
        {
            InitializeComponent();
        }

        private void From_Enter(object sender, EventArgs e)
        {
            if (From.Text == "From")
            {
                From.Text = "";
                From.ForeColor = Color.Black;
            }
        }

        private void To_Enter(object sender, EventArgs e)
        {
            if (To.Text == "To")
            { 
                To.Text = "";
                To.ForeColor = Color.Black;
            }
        }

        private void STMPServer_Enter(object sender, EventArgs e)
        {
            if (STMPServer.Text == "STMPServer")
            {
                STMPServer.Text = "";
                STMPServer.ForeColor = Color.Black;
            }
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username.Text == "Username")
            {
                Username.Text = "";
                Username.ForeColor = Color.Black;
            }
        }

        private void Subjent_Enter(object sender, EventArgs e)
        {
            if (Subject.Text == "Subject")
            {
                Subject.Text = "";
                Subject.ForeColor = Color.Black;
            }
        }

        private void Message_Enter(object sender, EventArgs e)
        {
            if (Mail.Text == "Message")
            {
                Mail.Text = "";
                Mail.ForeColor = Color.Black;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = "";
                Password.ForeColor = Color.Black;
                Password.UseSystemPasswordChar = true;
            }
        }

        private void From_Leave(object sender, EventArgs e)
        {
            if (From.Text == "")
            {
                From.Text = "From";
                From.ForeColor = Color.Silver;
            }
        }

        private void To_Leave(object sender, EventArgs e)
        {
            if (To.Text == "")
            {
                To.Text = "To";
                To.ForeColor = Color.Silver;
            }
        }

        private void STMPServer_Leave(object sender, EventArgs e)
        {
            if (STMPServer.Text == "")
            {
                STMPServer.Text = "STMPServer";
                STMPServer.ForeColor = Color.Silver;
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.Text = "Username";
                Username.ForeColor = Color.Silver;
            }
            
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {

                Password.Text = "Password";
                Password.ForeColor = Color.Silver;
                Password.UseSystemPasswordChar = false;
            }
        }

        private void Subject_Leave(object sender, EventArgs e)
        {
            if (Subject.Text == "")
            {
                Subject.Text = "Subject";
                Subject.ForeColor = Color.Silver;
            }
        }

        private void Message_Leave(object sender, EventArgs e)
        {
            if (Mail.Text == "")
            {
                Mail.Text = "Message";
                Mail.ForeColor = Color.Silver;
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(From.Text, To.Text, Subject.Text, Mail.Text);
            SmtpClient client = new SmtpClient(STMPServer.Text)
            {
                Port = 587,
                Credentials = new System.Net.NetworkCredential(Username.Text, Password.Text),
                EnableSsl = true
            };
            if(!string.IsNullOrEmpty(file))
            {
                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(file);
                mail.Attachments.Add(attachment);
            }
           


            client.Send(mail);
            MessageBox.Show("Mail sent", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void AttachmentButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogAttachment.ShowDialog();
            if (result == DialogResult.OK)
            {
                file = openFileDialogAttachment.FileName;
            }
            
        }
    }
}
