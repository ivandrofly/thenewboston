using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opening_Files_With_Your_App
{
    public partial class Form1 : Form
    {
        public Form1(string file)
        {
            InitializeComponent();
            MessageBox.Show(file);
        }
    }
}

/* Note:
 * http://www.youtube.com/watch?v=NpNqrrtrY24
 * To Make this application run you need to build it and go to bin|release folder
 * then drag a file over it it will show up the path of the file you drag in
*/
