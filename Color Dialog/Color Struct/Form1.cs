using System;
using System.Drawing;
using System.Windows.Forms;

namespace Color_Struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            //colorDialog.AllowFullOpen = false; // this will hide the custom color section
            colorDialog.FullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.HelpRequest += colorDialog_HelpRequest;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color _color = colorDialog.Color;
                button1.BackColor = colorDialog.Color;
                if (_color.IsNamedColor) MessageBox.Show("The color name is: " + _color.Name);

                if (_color.IsKnownColor) MessageBox.Show("The color is known color :" + _color.IsKnownColor.ToString());
                //KnownColor.WindowText
                Color myColor = Color.MintCream;
                MessageBox.Show(myColor.Name);

                Color mc = Color.FromKnownColor(KnownColor.GradientActiveCaption);
                int i = mc.ToArgb();
                Color mc1 = Color.FromArgb(i);
                MessageBox.Show("ToKnownColor = " + mc.ToKnownColor().ToString());
                MessageBox.Show("ToArgb-(x) = "mc.ToArgb().ToString("x"));
            }
        }

        /// <summary>
        /// this event will be raised once you clicked in help button in color dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void colorDialog_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Chosse a color for backgroup of your button");
        }
    }
}
