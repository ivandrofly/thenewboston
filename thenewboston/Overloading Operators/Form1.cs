using System;
using System.Windows.Forms;

namespace Overloading_Operators
{
    // Note: the static keyword are required to overload a operator
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item1 = new Item() { Price = 5 };
            var item2 = new Item() { Price = 5 };
            item1++;


            var r = item1 + item2;
            PrintMessage(r);

            var re = item1 == item2;
            PrintMessage(re);
        }


        private void PrintMessage(object obj)
        {
            MessageBox.Show(obj.ToString());
        }
    }

    class Item
    {
        public int Price { get; set; }

        public static Item operator +(Item left, Item right)
        {
            var result = new Item();
            result.Price = left.Price + right.Price;
            return result;
        }

        // Note: if you overload the <<==>> operator you must overload <<=!>>
        public static bool operator ==(Item left, Item right)
        {
            return left.Price == right.Price;
        }

        public static bool operator !=(Item left, Item right)
        {
            return (left.Price != right.Price) ? true : false;
        }

        public static bool operator >(Item left, Item right)
        {
            return (left.Price > right.Price) ? true : false;
        }


        public static bool operator <(Item left, Item right)
        {
            return (left.Price < right.Price) ? true : false;
        }

        public static bool operator >=(Item left, Item right)
        {
            return (left.Price >= right.Price) ? true : false;
        }

        public static bool operator <=(Item left, Item right)
        {
            return (left.Price <= right.Price) ? true : false;
        }

        public static Item operator ++(Item left)
        {
            return new Item() { Price = left.Price + 1 };
        }

        public static Item operator --(Item left)
        {
            return new Item() { Price = left.Price - 1 };
        }

        public override string ToString()
        {
            return this.Price.ToString();
        }
    }

}
