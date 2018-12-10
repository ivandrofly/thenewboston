using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_Shortcuts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox1.KeyDown += textBox1_KeyDown;
        }

        void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "F")
                MessageBox.Show("You pressed ctrl+f in textbox from the textbox");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // http://stackoverflow.com/questions/318160/what-is-the-difference-between-the-keycode-and-keydata-properties-on-the-net-wi
            /*
             KEYCODE is an enumeration that represents all the possible keys on the keyboard.
             KEYDATA is the KEYCODE combined with the modifiers (Ctrl, Alt and/or Shift).
             Use KeyCode when you don't care about the modifiers, KeyData when you do.
             */

            //if (e.Control && e.KeyCode.ToString() == "A")
            //    MessageBox.Show("Ivandro Ismael");

            if (e.KeyData == (Keys.Control | Keys.B))
            {
                MessageBox.Show("You just pressed B");
            }

            //if (e.Alt && e.Control)
            //    MessageBox.Show("You pressed alt and control");


            if (e.Control && e.KeyCode == Keys.F4)
            {
                // Be happy
                MessageBox.Show("Test");
            }

            int x = textBox1.Bottom;
            int y = textBox1.Right;

            // MSDN Example
            // http://msdn.microsoft.com/en-us/library/system.windows.forms.keyeventargs.keycode(v=vs.110).aspx
            // Determine whether the key entered is the F1 key. If it is, display Help. 
            if (e.KeyCode == Keys.F1 && (e.Alt || e.Control || e.Shift))
            {
                // Display a pop-up Help topic to assist the user.
                Help.ShowPopup(textBox1, "Enter your name.", new Point(textBox1.Bottom, textBox1.Right));
            }
            else if (e.KeyCode == Keys.F2 && e.Modifiers == Keys.Alt)
            {
                // Display a pop-up Help topic to provide additional assistance to the user.
                Help.ShowPopup(textBox1, "Enter your first name followed by your last name. Middle name is optional.",
                    new Point(textBox1.Top, this.textBox1.Left));
            }
        }

        /*
        void FileOrginizerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!gridView.CurrentCell.IsInEditMode)
            {
                if (e.KeyData == (Keys.Control | Keys.Z))
                {
                    this.editToolStripMenuItem.DropDownItems["Undo"].PerformClick();
                }
                else if (e.KeyData == (Keys.Control | Keys.Y))
                {
                    this.editToolStripMenuItem.DropDownItems["Redo"].PerformClick();
                }
                else if (e.KeyData == (Keys.Control | Keys.X))
                {
                    this.editToolStripMenuItem.DropDownItems["Cut"].PerformClick();
                }
                else if (e.KeyData == (Keys.Control | Keys.C))
                {
                    this.editToolStripMenuItem.DropDownItems["Copy"].PerformClick();
                }
                else if (e.KeyData == (Keys.Control | Keys.V))
                {
                    this.editToolStripMenuItem.DropDownItems["Paste"].PerformClick();
                }
                else if (e.KeyData == (Keys.Control | Keys.A))
                {

                    this.selectToolStripMenuItem.DropDownItems["Select All"].PerformClick();
                }
            }
        }
         */
    }
}
