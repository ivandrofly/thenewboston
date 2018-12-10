using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class myClass
    {
        public string this[int index]
        {
            get 
            {
                return MyArray[index];
            }
            set
            {
                // this will set the value to MyArray
                MyArray[index] = value; 
            }
        }

        string[] MyArray = { "Ivandro", "Ismael", "Gomes", "Jao" };
    }

}

