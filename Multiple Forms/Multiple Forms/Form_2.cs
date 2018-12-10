using System.Windows.Forms;

namespace Multiple_Forms
{
    public partial class Form_2 : Form
    {
        public string name;

        public Form_2(string mystring)
        {
            InitializeComponent();
            this.name = mystring;
            label1.Text = mystring;
        }
    }
}
