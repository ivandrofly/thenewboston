using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView___Control_Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode tnodes = new TreeNode();
            tnodes.Text = "person";
            tnodes.ImageIndex = 3;
            tnodes.SelectedImageIndex = 3;
            treeView1.Nodes.Add(tnodes);

            TreeNode tnodes1 = new TreeNode();
            tnodes1.Text = "Animal";
            tnodes1.ImageIndex = 0;
            tnodes1.SelectedImageIndex = 0; // this will prevent the image from change once you click in others index
            treeView1.Nodes.Add(tnodes1);

            TreeNode tnodes2 = new TreeNode();
            tnodes2.Text = "Cat";
            tnodes2.ImageIndex = 1;
            tnodes2.SelectedImageIndex = 1; // this will prevent the image from change once you click in others index
            treeView1.Nodes[0].Nodes.Add(tnodes2);
        }
    }
}
