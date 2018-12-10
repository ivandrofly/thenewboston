using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint_Projet_2
{
    public partial class Form1 : Form
    {
        private bool _canPaint = false;
        private Graphics _panelGraphics;

        private int? prevX = null;
        private int? prevY = null;

        public Form1()
        {
            InitializeComponent();

            this._panelGraphics = this.panel1.CreateGraphics();
            this.panel1.MouseUp += delegate
            {
                _canPaint = false;
            };
            this.panel1.MouseDown += delegate(object sender, MouseEventArgs e)
            {
                _canPaint = true;
                prevY = null;
                prevX = null;

                if (drawSquare)
                {
                    SolidBrush s = new SolidBrush(penColor.ForeColor);
                    _panelGraphics.FillRectangle(s, e.X, e.Y, 50, 50);
                    _canPaint = false;
                    drawSquare = false;
                }
                else if (drawRec)
                {
                    _panelGraphics.FillRectangle(Brushes.Blue, e.X, e.Y, 200, 100);
                    _canPaint = false;
                    drawRec = false;
                }
            };
            this.panel1.MouseMove += MouseMove;

            this.panel1.DragEnter += (s, e) =>
            {
                e.Effect = DragDropEffects.All;
            };

            this.panel1.DragDrop += (s, e) =>
            {
                string[] imagePath = e.Data.GetData(DataFormats.FileDrop) as string[];

                foreach (string path in imagePath)
                {
                    _panelGraphics.DrawImage(Image.FromFile(path), new Point(0, 0));
                }
            };
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            //float.Parse(toolStripTextBox1.Text)
            if (_canPaint)
            {
                /*SolidBrush sBrush = new SolidBrush(Color.Black);
                _panelGraphics.FillEllipse(sBrush, e.X, e.Y, Convert.ToInt32(toolStripTextBox1.Text), Convert.ToInt32(toolStripTextBox1.Text));
                 */
                int size;
                if (comboBoxSize.SelectedItem != null)
                {
                    int.TryParse(comboBoxSize.SelectedItem.ToString(), out size);
                }
                else
                    size = 2;

                Pen pen = new Pen(penColor.ForeColor, size == 0 ? 2 : size);
                _panelGraphics.DrawLine(pen, new Point(prevX ?? e.X, prevY ?? e.Y), new Point(e.X, e.Y));
                prevX = e.X;
                prevY = e.Y;
            }
            this.Invalidate();
        }

        private void canvasClear_Click(object sender, EventArgs e)
        {
            this.panel1.Invalidate();
            //this._panelGraphics.Clear(panel1.BackColor);
        }

        private void canvasColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                this.panel1.BackColor = cd.Color;
        }

        private void penColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                this.penColor.ForeColor = cd.Color;
        }

        // drawsquare
        private bool drawSquare = false;

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }

        // drawrectangle
        private bool drawRec = false;

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawRec = true;
        }

        // drawcircle
        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}