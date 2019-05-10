using HelpDeskUserInterface.AppData;
using HelpDeskUserInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskUserInterface.Core
{
    public static class EnumHelper
    {
        public static T StringToEnum<T>(string data)
        {
            return (T)Enum.Parse(typeof(T), data);
        }

        

    }
}
