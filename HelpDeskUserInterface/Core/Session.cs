using HelpDeskUserInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDeskUserInterface.Core
{
    public static class Session
    {
        public static User Registeringtime { get; set; }
        public static User User { get; set; }
        public static Form MainForm { get; set; }
        public static string Code { get; internal set; }


        //static Session()
        //{
        //    User = new User();
        //    MainForm = new Form();
        //}

    }
}
