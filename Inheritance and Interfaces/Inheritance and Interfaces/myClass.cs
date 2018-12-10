using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Interfaces
{

    class myClass
    {
        private string Name = "Bob";
        protected int Age = 10;
        public virtual void ShowMessage(string Message)
        {
            System.Windows.Forms.MessageBox.Show(Message);
        }
    }

    class mySecondClass : myClass, IMyIntercafe
    {
        public string HairColor = "Brown";
        public override void ShowMessage(string message)
        { 
            System.Windows.Forms.MessageBox.Show(message, "My Title");
        }

        public void MyVoid()
        {
            base.ShowMessage("My Void"); // is the method 
        }
    }

    interface IMyIntercafe
    {
        void MyVoid();
    }
}
