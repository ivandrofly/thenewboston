using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract internal class myClass
    {
        // this allow accencing it without object
        public static string Name = "Ivandro";
        public static int Age = 20;

        public static void Message(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

         abstract internal void ShowMessage(string message); // this can't be private but (public or protected)
    }

    class MySecondClass : myClass
    {
        public override void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
    }
}
