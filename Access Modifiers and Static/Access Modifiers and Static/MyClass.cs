using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers_and_Static
{
    class MyClass
    {
        public string _name;

        public MyClass(string x)
        {
            this._name = x;
        }

         string Name()
        {
            return this._name;
        }

         public static void ShowMessage(string x)
         {
             System.Windows.Forms.MessageBox.Show(x);
         }
    }
}
