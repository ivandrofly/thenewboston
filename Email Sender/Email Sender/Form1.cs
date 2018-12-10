using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBoxMail.Text.Contains("@gmail.com"))
                {
                    btnSendEmail.Enabled = false;
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(textBoxMail.Text);
                    message.Subject = textBoxSubjects.Text;
                    message.Body = textBoxBody.Text;
                    foreach (string mail in textBoxRecipiats.Text.Split(';'))
                        message.To.Add(mail);
                    SmtpClient client = new SmtpClient();
                    client.Credentials = new NetworkCredential(textBoxMail.Text, textBoxPwd.Text);
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.EnableSsl = true;
                    //client.Send(message); // this will crash the apps while sending the mail 'cause it's in same thread as email :)

                    // Fixe by: Ivandro Ismael
                    client.SendCompleted += client_SendCompleted;
                    client.SendAsync(message, "Message Sent Successfully");
                }
                else
                {
                    MessageBox.Show("You need to provide a email. from gmail.com");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An errors occuried");
            }
            finally
            {
                btnSendEmail.Enabled = true;
            }
        }

        void client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //MessageBox.Show(e.Error.Message); // this is returnin error
            MessageBox.Show(e.Cancelled.ToString());
            MessageBox.Show(e.UserState.ToString());
        }
    }
}
