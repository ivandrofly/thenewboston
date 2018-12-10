using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void MyDelegate(string x);

    class MyClass
    {
        public void ShowThoseMessage(string sentText = "Nothing Entered")
        {
            MyDelegate md = new MyDelegate(ShowMessage);
            md += ShowANotTheMessage;
            md(sentText);
        }
        void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show("I'm the show message: " + message);
        }

        void ShowANotTheMessage(string a)
        {
            System.Windows.Forms.MessageBox.Show("I'm ShowANotTheMessage: " + a);
        }
    }
}
