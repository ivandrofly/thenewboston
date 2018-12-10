using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    partial class MyClass
    {
        public String Name = "Mr. Salth";
        public int Age = 30;
        partial void Message(string message);
    }
}
