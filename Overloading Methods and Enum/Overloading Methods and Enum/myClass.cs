using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Methods_and_Enum
{
    enum Names
    {
        Ivandro = 1, //the next will be equal to 2 this is overriding enumeration
        Ismael = 2, 
        Gomes = 4, 
        Jao
    }

    //enum Names : byte
    //{
    //    Ivandro = 1, //the next will be equal to 2 this is overriding enumeration
    //    Ismael = 2,
    //    Gomes = 4,
    //    Jao
    //}


    class myClass
    {
        public string name;

        Names myName = Names.Ivandro;

        public myClass()
        {

        }

        public myClass(string x)
        {

        }

        // Overloading
        public static void ShowMessage(int x) 
        {
            System.Windows.Forms.MessageBox.Show(x.ToString());
        }
        public static void ShowMessage(string x)
        {
            System.Windows.Forms.MessageBox.Show(x);
        }
    }
}
