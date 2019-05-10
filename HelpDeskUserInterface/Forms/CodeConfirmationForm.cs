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
    public partial class CodeConfirmationForm : Form
    {
        public CodeConfirmationForm()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string code = txbx_confirm_code.Text;
            if(code == Session.Code)
            {
                Session.User.IsEmailConfirmed = true;
            }
        }
    }
}
