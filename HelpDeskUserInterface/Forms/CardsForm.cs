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
    public partial class CardsForm : Form
    {
        public CardsForm()
        {
            InitializeComponent();
        }

        private void CardsForm_Load(object sender, EventArgs e)
        {
            var datas = DbContext.Cards.GetAll();
            dgv_cards.DataSource = datas;
        }
    }
}
