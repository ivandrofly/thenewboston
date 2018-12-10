using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throwing_Exceptions
{
    class myClass
    {            
        static Exception myException = new Exception("You can't set the to string to empty string :D");
        public static void CheckingString(string myString)
        {
            //if (myString == "") throw new Exception("You can't set the to string to empty string ;)!");
            if (myString == "") throw myException;
        }
    }
}
