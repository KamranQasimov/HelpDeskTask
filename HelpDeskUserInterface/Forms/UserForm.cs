using HelpDeskUserInterface.AppData;
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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            dgv_users.DataSource = DbContext.Users.GetAll();
        }

        private void dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
