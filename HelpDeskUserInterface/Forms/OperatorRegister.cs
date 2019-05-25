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
    public partial class OperatorRegister : Form
    {
        public OperatorRegister()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if(txbx_password.Text != txbx_confirm_password.Text)
            {
                MessageBox.Show("Password is not same ");
                return;
            }
            Operator @operator = new Operator
            {
                Name = txbx_name.Text,
                Surname = txbx_surname.Text,
                Email = txbx_email.Text,
                Password = txbx_password.Text,
                Id = Identifier<Operator>.GenerateIdentifier(),
                UserType = UserType.Operator

            };
            DbContext.Operators.Add(@operator);
            MessageBox.Show("Operator added successfully =)");
            
        }
    }
}
