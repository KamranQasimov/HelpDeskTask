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
        private static void InitializeDefaultUsers()
        {
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
            InitializeDefaultUsers(); 
            
        }
    }
}
