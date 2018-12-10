using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] myArray = new string[4];

            List<string> names = new List<string>();
            names.Add("Ismael");
            MessageBox.Show(names[0]);


            List<int> numbers = new List<int>();
            numbers.Add(23422);
            MessageBox.Show(numbers[0].ToString());
            
        }
    }
}
