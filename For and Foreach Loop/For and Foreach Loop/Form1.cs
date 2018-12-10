using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_and_Foreach_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if there is no condition the loop will be infinite (i<2)*/
            //for (int i = 0; i < 2; i++)
            //{
            //    MessageBox.Show(i.ToString());
            //}

            string[] name = { "Ivandro", "Ismael", "Jao", "Gomes" };
            foreach (string x in name)
            {
                MessageBox.Show(x);
            }
            

            List<int> mylist = new List<int>();
            mylist.Add(342);
            mylist.Add(23);
            mylist.Add(2);
            foreach(int x in mylist)
            {
                MessageBox.Show(x.ToString());
            }

        }
    }
}
