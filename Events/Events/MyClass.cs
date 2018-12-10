using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class MyClass
    {
        public event EventHandler OnPropertyChanged;
        public event EventHandler MethodIvandroCalled;
        //public event Action myAction;
        string name = "";

        public string  Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
                OnPropertyChanged(this, new EventArgs()); // this will raise all the events assgined on him
                OnPropertyChanged.Invoke(this, new EventArgs());
            }
        }
        
        // Made by Ivandro Ismael
        public void ivandro()
        {
            EventArgs e = new EventArgs();
            this.MethodIvandroCalled(this, e);
        }
    }
}
