using HelpDeskUserInterface.Core;
using HelpDeskUserInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskUserInterface.AppData
{
    class DbContext
    {
        public static DbSet<Card> Cards { get; set; }
        public static DbSet<User> Users { get; set; }
        public static DbSet<Ticket> Tickets { get; set; }
        private static void InitializeDefaultUsers()
        {
            Users.Add(new User
            {
                Email = "kamran@gmail.com",
                Id = Identifier<User>.GenerateIdentifier(),
                Name = "Kamran",
                Surname = "Qasimov",
                Password = "12345",
                UserType = UserType.User
            });
            Users.Add(new User
            {
                Email = "admin@gmail.com",
                Id = Identifier<User>.GenerateIdentifier(),
                Name = "Admin",
                Surname = "Admin",
                Password = "12345",
                UserType = UserType.Admin
            });
        }
        static DbContext()
        {
            Cards = new DbSet<Card>();
            Users = new DbSet<User>();
            Tickets = new DbSet<Ticket>();
            InitializeDefaultUsers(); 
            
        }
    }
}
