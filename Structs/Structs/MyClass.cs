using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    struct Client : IClient
    {
        //public Client(string name ) // Struct constructor must have at least one parametre
        //{
        //    Name = name;
        //    Age = 0;
        //}

        public string Name;
        public int? Age;

        public override string ToString()
        {
            return Name + " " + Age;
        }

        public void ClearClientInfo()
        {
            Name = null;
            Age = null;
        }
    }

    // Interface cannot have access modifiers
    interface IClient
    {
        // public string Name; // this will not work because the interface can't 
        void ClearClientInfo();
    }

    class MyClass
    {
    }
}
