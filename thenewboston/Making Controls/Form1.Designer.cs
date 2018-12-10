namespace Making_Controls
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
            this.myButton1 = new Making_Controls.MyButton();
            this.advCtrl1 = new Making_Controls.AdvCtrl();
            this.SuspendLayout();
            // 
            // myButton1
            // 
            this.myButton1.ButtonColor = System.Drawing.Color.Yellow;
            this.myButton1.ButtonText = "Ivandro Ismael";
            this.myButton1.Location = new System.Drawing.Point(210, 98);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(218, 109);
            this.myButton1.TabIndex = 0;
            // 
            // advCtrl1
            // 
            this.advCtrl1.Location = new System.Drawing.Point(12, 12);
            this.advCtrl1.Name = "advCtrl1";
            this.advCtrl1.Size = new System.Drawing.Size(150, 30);
            this.advCtrl1.TabIndex = 1;
            this.advCtrl1.Text = "Ivandro Ismael";
            this.advCtrl1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(640, 313);
            this.Controls.Add(this.advCtrl1);
            this.Controls.Add(this.myButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton myButton1;
        private AdvCtrl advCtrl1;
    }
}

