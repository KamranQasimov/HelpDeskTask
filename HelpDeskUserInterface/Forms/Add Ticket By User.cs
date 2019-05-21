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
    
    public partial class Add_Ticket_By_User : Form
    {
        private UserDashboard _userDashboard;
        public Add_Ticket_By_User(UserDashboard userDashboard)
        {
            InitializeComponent();
            _userDashboard = userDashboard;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ticket myTicket = new Ticket
            {
                Description = txbx_description.Text,
                Title = txbx_title.Text,
                UserId = Session.User.Id,
                TicketStatus = TicketStatus.Open,
                Id = Identifier<Ticket>.GenerateIdentifier()

            };

            DbContext.Tickets.Add(myTicket);
            MessageBox.Show("You sended ticket successfully");
        }
    }
}
