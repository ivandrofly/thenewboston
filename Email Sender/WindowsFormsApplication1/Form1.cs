using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> mylist = new List<string>();
            string[] ivandro = {"ivandro", "iamel","jao"};

            foreach (var item in ivandro)
                mylist.Add(item);
            MessageBox.Show("ivandro");
        }
    }
}
