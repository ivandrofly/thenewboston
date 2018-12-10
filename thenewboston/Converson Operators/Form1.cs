using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converson_Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Item i = (Item)3;
            Item i = 3;
            PrintMessage(i.Price);


        }

        private void PrintMessage(int val)
        {
            MessageBox.Show(val.ToString());
        }
    }

    class Item
    {
        public int Price { get; set; }

        // Note: only one by time
        public static implicit operator Item(int itemPrice)
        {
            Item i = new Item();
            i.Price = itemPrice;
            return i;
        }

        /*
        public static explicit operator Item(int itemPrice)
        {
            Item i = new Item();
            i.Price = itemPrice;
            return i;
        */
    }
}
