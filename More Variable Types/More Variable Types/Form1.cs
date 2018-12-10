using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace More_Variable_Types
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sbyte myBytes = -2; // this is the signed byte unsigned byte means that your can only signed it between 0-255, to make it signed you (sbytes)
            ushort myShort = 0; // the u keyword will make it unsigned
            UInt16 int16 = myShort; // Note: the <U> must be with capital letter
            uint myInt = 0;
            UInt32 myInt32 = myInt;
            ulong myLong = 0;
            UInt64 myInt64 = myLong;
            
            //float myFloat = -3243234;
            float myFloat = 0.5F; // this is the decimal point the F keyword will tell the compiller its a float this is very important to know

            double d = 0.5;
            char c = 'c'; // this is how to assign char
            MessageBox.Show(myFloat.ToString());

        }
    }
}
