using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            using (ivandro Ivandro = new ivandro())
            {
                Ivandro.Printout();
            }
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            // this will only  the new event with is the methods mc_OnPropertyChanged
            mc.OnPropertyChanged += mc_OnPropertyChanged;
            mc.OnPropertyChanged += thisMessage;
            mc.Name = "Ivandro"; //this will raise the events


            // after += if you press the tab x2 it will create the method automaticly
            mc.MethodIvandroCalled += mc_MethodIvandroCalled;
            mc.ivandro();
        }


        void mc_OnPropertyChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The Property has changed");
        }

        void thisMessage(object sender, EventArgs e)
        { 
            MessageBox.Show("I'm the second raised event"); 
        }

        void mc_MethodIvandroCalled(object sender, EventArgs e)
        {
            MessageBox.Show("I'm the MethodIvandroCallEvent");

            //using (Font font1 = new Font("Arial", 10.0f))
            //{
            //    MessageBox.Show(font1.Name.ToString()); 
            //}
        }
    }
}

public class ivandro : IDisposable
{
    public void Printout()
    { MessageBox.Show("Test"); }

    public void Dispose()
    {
        Console.WriteLine("Disposing limited resource.");
    }
}