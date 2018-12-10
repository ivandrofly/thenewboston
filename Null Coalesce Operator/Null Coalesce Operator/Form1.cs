using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Null_Coalesce_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myString = null;
            int? i = null;
            int x = i ?? 8; // if 'i' is null, than x will be 8 else it willbe the i is value
            MessageBox.Show(x.ToString());
            this.Close();

            MessageBox.Show(myString ?? "String is null");
            
            // Ternary Operator
            int Number = 18;
            bool IsNumber10 = (Number == 10) ? true : false;
            Console.WriteLine(IsNumber10);
        }
    }
}
