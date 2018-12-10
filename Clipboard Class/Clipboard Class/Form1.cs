using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipboard_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"http://www.informationsecuritybuzz.com/securitybuzz/wp-content/uploads/is1313.jpg";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Clipboard.GetText();
            pictureBox2.Image = Clipboard.GetImage();
            Clipboard.SetText("ivandro");
            Clipboard.Clear();
        }
    }
}
