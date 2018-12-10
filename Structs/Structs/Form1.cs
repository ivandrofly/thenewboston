using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Client client1 = new Client();
        Client client2 = new Client();
        private void button1_Click(object sender, EventArgs e)
        {
            // Client 1
            client1.Name = "Ivandro Ismael Gomes Jao ";
            client1.Age = 10 *2;
            
            // Client 2
            client2.Age = 20;
            client2.Name = "Subscene Web Site ";
            //client2.ClearClientInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(client2.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(client1.ToString());
        }
    }
}
