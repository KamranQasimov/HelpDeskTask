using HelpDeskUserInterface.Core;
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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void lbl_greeting_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lbl_greeting.Text += Session.User.Email;
        }

        private void link_add_card_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AddCard().ShowDialog();
        }

        private void link_cards_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CardsForm().ShowDialog();
        }

        private void link_user_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UserForm().ShowDialog();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Session.MainForm.Show();
            this.Close();
        }

        private void link_operator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new OperatorRegister().ShowDialog();
        }
    }
}
