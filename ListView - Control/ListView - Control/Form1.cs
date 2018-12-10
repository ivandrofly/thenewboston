using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView___Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            ListViewItem listItems = new ListViewItem(textBoxFullName.Text);
            listItems.SubItems.Add(textBoxEmail.Text);
            listItems.SubItems.Add(textBoxAge.Text);
            listViewPerson.Items.Add(listItems);

            ResetFields();
        }

        private void ResetFields()
        {
            textBoxEmail.Text = "";
            textBoxAge.Text = "";
            textBoxFullName.Text = "";
        }

        private void getItemNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewPerson.SelectedItems.Count != 0)
            {
                //MessageBox.Show(listViewPerson.SelectedItems[0].SubItems[0].Text);
                foreach (ListViewItem item in listViewPerson.SelectedItems)
                {
                    MessageBox.Show(item.SubItems[0].Text);
                }
            }
        }

        private void getItemsEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewPerson.SelectedItems.Count != 0)
            {
                //MessageBox.Show(listViewPerson.SelectedItems[0].SubItems[0].Text);
                foreach (ListViewItem item in listViewPerson.SelectedItems)
                {
                    MessageBox.Show(item.SubItems[1].Text);
                }
            }
        }

        private void removeSelectedItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewPerson.SelectedItems.Count != 0)
            {
                //MessageBox.Show(listViewPerson.SelectedItems[0].SubItems[0].Text);
                foreach (ListViewItem item in listViewPerson.SelectedItems)
                {
                    listViewPerson.Items.Remove(item);
                    //item.Remove();
                }
            }
        }

        private void removeAllItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewPerson.Clear();
        }

        private void buttonRemoveCheckedItems_Click(object sender, EventArgs e)
        {
            if (listViewPerson.SelectedItems.Count != 0)
            {
                foreach (ListViewItem item in listViewPerson.Items)
                {
                    if (item.Checked)
                    {
                        item.Remove();
                    }
                }
            }
        }
    }
}
