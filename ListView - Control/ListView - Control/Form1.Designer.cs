namespace ListView___Control
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewPerson = new System.Windows.Forms.ListView();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.getItemNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getItemsEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRemoveCheckedItems = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPerson
            // 
            this.listViewPerson.CheckBoxes = true;
            this.listViewPerson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewPerson.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewPerson.FullRowSelect = true;
            this.listViewPerson.GridLines = true;
            this.listViewPerson.Location = new System.Drawing.Point(12, 101);
            this.listViewPerson.Name = "listViewPerson";
            this.listViewPerson.Size = new System.Drawing.Size(435, 181);
            this.listViewPerson.TabIndex = 0;
            this.listViewPerson.UseCompatibleStateImageBehavior = false;
            this.listViewPerson.View = System.Windows.Forms.View.Details;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(81, 22);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(190, 20);
            this.textBoxFullName.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(81, 46);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(190, 20);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(81, 72);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(47, 20);
            this.textBoxAge.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full-Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age:";
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.Location = new System.Drawing.Point(328, 72);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(119, 23);
            this.buttonAddPerson.TabIndex = 7;
            this.buttonAddPerson.Text = "Add Person";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Full-Name";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 173;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Age";
            this.columnHeader3.Width = 77;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getItemNameToolStripMenuItem,
            this.getItemsEmailToolStripMenuItem,
            this.removeSelectedItemsToolStripMenuItem,
            this.removeAllItemsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 92);
            // 
            // getItemNameToolStripMenuItem
            // 
            this.getItemNameToolStripMenuItem.Name = "getItemNameToolStripMenuItem";
            this.getItemNameToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.getItemNameToolStripMenuItem.Text = "Get Item(s) Name";
            this.getItemNameToolStripMenuItem.Click += new System.EventHandler(this.getItemNameToolStripMenuItem_Click);
            // 
            // getItemsEmailToolStripMenuItem
            // 
            this.getItemsEmailToolStripMenuItem.Name = "getItemsEmailToolStripMenuItem";
            this.getItemsEmailToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.getItemsEmailToolStripMenuItem.Text = "Get Item(s) Email";
            this.getItemsEmailToolStripMenuItem.Click += new System.EventHandler(this.getItemsEmailToolStripMenuItem_Click);
            // 
            // removeSelectedItemsToolStripMenuItem
            // 
            this.removeSelectedItemsToolStripMenuItem.Name = "removeSelectedItemsToolStripMenuItem";
            this.removeSelectedItemsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.removeSelectedItemsToolStripMenuItem.Text = "Remove Selected Item(s)";
            this.removeSelectedItemsToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedItemsToolStripMenuItem_Click);
            // 
            // removeAllItemsToolStripMenuItem
            // 
            this.removeAllItemsToolStripMenuItem.Name = "removeAllItemsToolStripMenuItem";
            this.removeAllItemsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.removeAllItemsToolStripMenuItem.Text = "Remove All Items";
            this.removeAllItemsToolStripMenuItem.Click += new System.EventHandler(this.removeAllItemsToolStripMenuItem_Click);
            // 
            // buttonRemoveCheckedItems
            // 
            this.buttonRemoveCheckedItems.Location = new System.Drawing.Point(197, 72);
            this.buttonRemoveCheckedItems.Name = "buttonRemoveCheckedItems";
            this.buttonRemoveCheckedItems.Size = new System.Drawing.Size(125, 23);
            this.buttonRemoveCheckedItems.TabIndex = 9;
            this.buttonRemoveCheckedItems.Text = "Remove Checked";
            this.buttonRemoveCheckedItems.UseVisualStyleBackColor = true;
            this.buttonRemoveCheckedItems.Click += new System.EventHandler(this.buttonRemoveCheckedItems_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 294);
            this.Controls.Add(this.buttonRemoveCheckedItems);
            this.Controls.Add(this.buttonAddPerson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.listViewPerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPerson;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem getItemNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getItemsEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllItemsToolStripMenuItem;
        private System.Windows.Forms.Button buttonRemoveCheckedItems;
    }
}

