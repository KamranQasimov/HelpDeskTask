using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskUserInterface.Core
{
    public class Identifier<T>
    {
        private static int _identifier;

        static Identifier()
        {
            _identifier = 0;
        }
        public static int GenerateIdentifier()
        {
            _identifier++;
            return _identifier; 
        }
        

    }
}
