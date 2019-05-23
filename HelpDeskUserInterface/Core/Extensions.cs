using HelpDeskUserInterface.AppData;
using HelpDeskUserInterface.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskUserInterface.Core
{
    public static class Extensions
    {
        public static Card FindCardByNumber(this DbSet<Card> dbset, string cardNumber)
        {
            Card _card = null;
            foreach (Card card in dbset.GetAll())
            {
                if (card.Number == cardNumber)
                {
                    _card = card;
                    break;
                }
            }
            return _card;
        }

        

        public static User FindUser(this DbSet<User> users,string email,string password)
        {
            User _user = null;
            foreach (User user in users.GetAll())
            {
                if (user.Email == email && user.Password == password)
                {
                    _user = user;
                    break;
                }
                    
            }
            return _user;
        }

        public static List<Ticket> FindUsersTicket(this DbSet<Ticket> tickets, User user)
        {
           List<Ticket> _ticket = new List<Ticket>();
            //User user = Session.User;
            foreach (Ticket ticket in tickets.GetAll())
            {
                if (ticket.UserId == user.Id)
                {
                    _ticket.Add( ticket);
                    //break;
                }

            }
            return _ticket;
        }
    }
    
    
}
