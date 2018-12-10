using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView___Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("People");
            treeView1.Nodes[0].Nodes.Add("Djyba");
            treeView1.Nodes[0].Nodes.Add("Heidy");
            treeView1.Nodes[0].Nodes.Add("Ivanildo");
            treeView1.Nodes[0].Nodes.Add("Ivandro");

            treeView1.Nodes.Add("Animal");
            treeView1.Nodes[1].Nodes.Add("Dog");
            treeView1.Nodes[1].Nodes.Add("Cat");
            treeView1.Nodes[1].Nodes.Add("Lion");
            treeView1.Nodes[1].Nodes.Add("Snake");
            treeView1.Nodes[1].Nodes[0].Nodes.Add("Simba");

        }

        private void buttonRemoveNodes_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        List<TreeNode> listCheckNodes = new List<TreeNode>();
        void RemoveCheckedNodes(TreeNodeCollection NodesCollections)
        {
            foreach (TreeNode node in NodesCollections)
                if (node.Checked)
                {
                    listCheckNodes.Add(node);
                }
                else if (node.Nodes.Count != 0)
                {
                    RemoveCheckedNodes(node.Nodes);
                }

            foreach (TreeNode checkedNode in listCheckNodes)
                treeView1.Nodes.Remove(checkedNode);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveCheckedNodes(treeView1.Nodes);
        }

    }
}
