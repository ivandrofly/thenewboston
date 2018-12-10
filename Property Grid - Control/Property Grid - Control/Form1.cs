using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Property_Grid___Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Person p = new Person();
        private void button1_Click(object sender, EventArgs e)
        {
            p.Name = "Ivandro";
            p.Age = 20;
            p.Email = "ivandrofly@gmail.com";
            // once the button1 is clicked it is going the set all the properties from the button1 in property grid
            propertyGrid1.SelectedObject = p;
            Reload();
        }

        private void Reload()
        {
            textBox1.Text = p.Name;
            textBox2.Text = p.Age.ToString();
            textBox3.Text = p.Email;
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            Reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] names = { "ismael", "ivandro", "paulo" };
            MessageBox.Show(names.Length.ToString());
        }

    }

    public class Person
    {
        private string _errorMessage = "Because I said so";

        [DisplayName("Get name")]
        [Description("This is the get name property")]
        [Category("Person")]
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        [DisplayName("Get Car Name and Manufactory")]
        [Description("This is the get Carname Manufactory")]
        [Category("Car")]
        public string CarName { get; set; }
        public string Manufcatory { get; set; }


        [DisplayName("Shows if there is a error")]
        [Description("This is the error")]
        [Category("Error Message")]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
    }
}
