using System;
using System.Windows.Forms;
using System.IO;
namespace StreamReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fs = new OpenFileDialog();
            if (fs.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader thisReader = new System.IO.StreamReader(File.OpenRead(fs.FileName));
                char c = (char)thisReader.Peek(); //0
                char i = (char)thisReader.Peek(); //0 // Works only for character

                char c1 = (char)thisReader.Read(); //0 and it will cosume it :)
                char c2 = (char)thisReader.Read(); //1
                MessageBox.Show(i.ToString() + ":" + c1.ToString() + ":" + c2.ToString());

                //  //textBox1.Text = SR.BaseStream.ReadByte().ToString("X"); // this will convert it to Hex and it will only read the first char
                //SR.BaseStream.Position = 0x0C;
                //byte[] buffer = new Byte[3];
                //SR.BaseStream.Read(buffer, 0, 3); // this will start in Position 0x0C
                //foreach (byte myBytes in buffer)
                //{
                //    textBox1.Text += myBytes.ToString("X") + " ";
                //}

                thisReader.Dispose();
            }
        }
    }
}
