using HelpDeskUserInterface.AppData;
using HelpDeskUserInterface.Core;
using HelpDeskUserInterface.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDeskUserInterface.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txbx_email.Text) && !string.IsNullOrEmpty(txbx_password.Text))
            {
                User user= DbContext.Users.FindUser(txbx_email.Text, txbx_password.Text);
                if (user != null)
                {
                    Session.User = user;
                    if (user.UserType == UserType.Admin)
                    {
                        new AdminDashboard().Show();
                        this.Close();
                    }
                    else
                    {
                        new UserDashboard().Show();
                        this.Close();
                    }
                    
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
