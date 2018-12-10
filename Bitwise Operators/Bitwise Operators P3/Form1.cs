using System;
using System.Windows.Forms;

namespace Bitwise_Operators_P3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Xor
            // 3 = 0011
            // 5 = 0101
            // R = 0110
            // Note: the bytes has to be different in order to get a 1
            short myShort = 3 ^ 5;
            //MessageBox.Show(Convert.ToString(myShort, 2));

            // Right Shift
            // 3 = 101
            // Note: it will shift the 10 and '1' will be cutted
            // R = 10
            short myShort1 = 5 >> 1;
            //MessageBox.Show(Convert.ToString(myShort1, 2));


            // LEFT SHIFT
            // 1011 = 11
            // 0011 = 3 
            // 1011 < 000 Note this 000 zeros will be added and 3 value will be remove at the beggining (101) in (1011)
            // http://tinyurl.com/nhhwdbr

            // 11 << 3 = 11000
            // Note: Some time the value don't get cutted its keeped...
            // R = 10
            short myShort12 = 3 << 1;
            MessageBox.Show(Convert.ToString(myShort12, 2));
        }
    }
}
