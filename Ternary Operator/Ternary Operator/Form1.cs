using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ternary_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string myString = "";
            //if (checkBox1.Checked) myString = "It's checked";
            //else myString = "It's not checked";

            //string MyString = (checkBox1.Checked) ? "It's checked" : "Its not checkd";

            MessageBox.Show((checkBox1.Checked) ? "It's checked" : "Its not checkd");


            // this ill check for null datatype if its it will return 0
            int? TicketsOnSale = 100;
            int AvailableTickets = TicketsOnSale ?? 0;
            MessageBox.Show(AvailableTickets.ToString());
        }
    }
}
