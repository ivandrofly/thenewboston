using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generate_Random_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] letters = "qwertyuiopasdfghjklçzxcvbnm123457890".ToCharArray();
            Random r = new Random();
            MessageBox.Show(letters[r.Next(0, 24)].ToString());
            string randomString = null;
            for (int i = 0; i < 10; i++)
            {
                randomString += letters[r.Next(0,35)].ToString();
            }
            MessageBox.Show(randomString);
        }
    }
}
