using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelpDeskUserInterface.Models;
using HelpDeskUserInterface.Core;
using HelpDeskUserInterface.AppData;

namespace HelpDeskUserInterface
{
    public partial class AddCard : Form
    {
        public AddCard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_generate_card_Click(object sender, EventArgs e)
        {
            string guid = Guid.NewGuid().ToString();
            guid = guid.Substring(guid.IndexOf('-')+1, 14);
            txbx_card_number.Text = guid.ToUpper();

            Random random = new Random();
            int number = random.Next(0, 4);

           CardAmountType[] enumValues = (CardAmountType[])Enum.GetValues(typeof(CardAmountType));
            CardAmountType cardAmountType = enumValues[number];
            txbx_card_amoun.Text = ((int)cardAmountType).ToString();

            CardData cardData = new CardData();
            MonthType monthType = cardData.GetDataByAmountType(cardAmountType);
            txbx_card_expire_date.Text = DateTime.Now.AddMonths((int)monthType).ToString();
           
             
        }

        private void btn_add_card_Click(object sender, EventArgs e)
        {
            CardAmountType amountType = EnumHelper.StringToEnum<CardAmountType>(txbx_card_amoun.Text);
            DateTime expireDate = DateTime.Parse(txbx_card_expire_date.Text);
            Card card = new Card()
            {
                CreateDate = DateTime.Now,
                CardAmountType = amountType,
                ExpireDate = expireDate,
                Number = txbx_card_number.Text,
                Id = Identifier<Card>.GenerateIdentifier()

            };

            DbContext.Cards.Add(card);
            DrawStatistics();
        }

        private void AddCard_Load(object sender, EventArgs e)
        {
            DrawStatistics();
        }
        private void DrawStatistics()
        {
            int count = DbContext.Cards.GetAll().Count;
            link_item_count.Text = count.ToString();
        }
    }
}
