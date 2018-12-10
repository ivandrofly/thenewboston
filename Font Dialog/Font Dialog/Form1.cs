using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Font_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.MinSize = 10; // set the minumum font size to 10
            fd.MaxSize = 20; // set the maximum font size to 20
            fd.ShowColor = true;
            fd.ShowHelp = true;
            fd.HelpRequest += fd_HelpRequest;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = fd.Color;
                textBox1.Font = fd.Font;
                this.Text = "Current Font is: " + fd.Font.Name.ToString();
            }
        }

        void fd_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Choose a font and color");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                MessageBox.Show("Test");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Up && e.Modifiers == Keys.Control)
            //{
            //    MessageBox.Show("Test");
            //}

            //if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Up)
            //{
            //    //MessageBox.Show("Test");
            //}
            //e.Handled = false;

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Delete)
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            this.Text = e.KeyCode.ToString();
        }

    }
}


//private void Form_KeyDown(object sender, KeyEventArgs e)
//{
//    e.Handled = ProcessKeyDown(e.KeyCode);
//}

//// event handler for the PreViewKeyDown event for the buttons
//private void ArrowButton_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
//{
//    ProcessKeyDown(e.KeyCode);

//}

//private bool ProcessKeyDown(Keys keyCode)
//{
//    switch (keyCode)
//    {
//        case Keys.Up:
//            {
//                // act on up arrow
//                return true;
//            }
//        case Keys.Down:
//            {
//                // act on down arrow
//                return true;
//            }
//        case Keys.Left:
//            {
//                // act on left arrow
//                return true;
//            }
//        case Keys.Right:
//            {
//                // act on right arrow
//                return true;
//            }
//    }
//    return false;
//}