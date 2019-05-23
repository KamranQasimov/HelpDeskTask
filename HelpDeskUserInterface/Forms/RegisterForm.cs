using HelpDeskUserInterface.AppData;
using HelpDeskUserInterface.Core;
using HelpDeskUserInterface.Models;
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

namespace HelpDeskUserInterface.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if(txbx_password.Text != txbx_confirm_password.Text)
            {
                MessageBox.Show("Passwords are not same!");
                    return;
            }

            User user = new User
            {
                //Email = txbx_email.Text,
                Email = txbx_email.Text,
                Name = txbx_name.Text,
                Password = txbx_password.Text,
                Surname = txbx_surname.Text,
                UserType = UserType.User,
                Id = Identifier<User>.GenerateIdentifier(),
                IsEmailConfirmed = false
                
            };
            //DbContext.Users.Add(user);
            Session.Registeringtime = user;
            SendEmail(txbx_email.Text);
            new CodeConfirmationForm().ShowDialog();
            
            //MessageBox.Show("User successully added");

        }
        
        private void SendEmail(string email)
        {
            MailMessage mailMessage = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("kamran.test.backend@gmail.com", "KQ17782026")
            };
            Random random = new Random();
            int code = random.Next(1000, 9999);
            Session.Code = code.ToString();
            string message = "Dear user your confirmation code is " + code;
            smtpClient.EnableSsl = true;
            mailMessage.To.Add(email);
            mailMessage.From = new MailAddress("kamran.test.backend@gmail.com", "OnlineHelpDesk");
            mailMessage.Subject = "Code confirmation for OnlineHelpDesk";
            mailMessage.Body = message;
            smtpClient.Send(mailMessage);
        }




        //private void SendEmail(string to)
        //{
        //    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)

        //    {
                
        //        Credentials = new NetworkCredential("kamran.test.backend@gmail.com", "KQ17782026"),
        //        EnableSsl = true

        //    };
        //    Random random = new Random();
        //    int code = random.Next(1000, 9999);
        //    Session.Code = code.ToString();
        //    string message = $"Yor confirmation code is {code}";
        //    smtpClient.Send("kamran.test.backend@gmail.com", to, "Codde confirmation for OnlineHelpDesk", message);
        //}

        private void btn_card_register_Click(object sender, EventArgs e)
        {
            if(txbx_card_password.Text != txbx_card_ConfirmPassword.Text)
            {

                MessageBox.Show("Passwords are not same!");
                    return;
            }
            Card card = DbContext.Cards.FindCardByNumber(txbx_card_number.Text);
            if(card == null)
            {
                MessageBox.Show("Card number is not valid");
                return;
            }
            User user = new User
            {
                Email = txbx_card_email.Text,
                Password = txbx_card_password.Text,
                UserType = UserType.User,
                Id = Identifier<User>.GenerateIdentifier()

            };
            DbContext.Users.Add(user);
            MessageBox.Show("User successully registered");

        }

        private void link_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Session.MainForm = this;
            new LoginForm().ShowDialog();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
