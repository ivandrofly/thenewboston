using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Overriding
{
    class myClass
    {
        private string Name = "Bob";
        protected int Age = 10;
        // to use the public new void I did use the virtual keyword
        public virtual void ShowMessage(string Message)
        {
            System.Windows.Forms.MessageBox.Show(Message);
        }
    }

    class MySourceClass : myClass
    {
        public string HairColor = "Black";

        public void MessageBoxSpecial()
        {
            //System.Windows.Forms.MessageBox.Show(base.Age.ToString());
            //base.ShowMessage(base.Age.ToString());
        }

        // this will overrides | Hide 
        //public new void ShowMessage(string message)
        //{
        //    System.Windows.Forms.MessageBox.Show(message);
        //}

        public override void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

    }
}
