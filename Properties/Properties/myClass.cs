using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class myClass
    {
        public myClass(string x)
        {
            _name = x;
            
        }

        private string _name;
        // Property
        public string Name
        {
            get { return this._name; }
            set { if (value == "") System.Windows.Forms.MessageBox.Show("you can't do that"); }
        }
    }
}
