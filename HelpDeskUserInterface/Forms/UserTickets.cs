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
using HelpDeskUserInterface.Core;
using HelpDeskUserInterface.Models;

namespace HelpDeskUserInterface.Forms
{
    public partial class UserTickets : Form
    {
        public UserTickets()
        {
            InitializeComponent();
        }

        private void UserTickets_Load(object sender, EventArgs e)
        {
            dgv_user_tickets.DataSource = DbContext.Tickets.FindUsersTicket(Session.User);
            //dgv_user_tickets.DataSource = DbContext.Tickets.GetAll();
            





        }

        
    }
}
