using System.Drawing;
using System.Windows.Forms;

namespace Making_Controls
{
    public partial class MyButton : UserControl
    {
        string text = string.Empty;
        private Color buttonColor = Color.FromKnownColor(KnownColor.Control);

        public string ButtonText
        {
            get { return text; }
            set { text = value; }
        }

        public Color ButtonColor
        {
            get { return buttonColor; }
            set { try { buttonColor = value; } catch { buttonColor = Color.FromKnownColor(KnownColor.Control); MessageBox.Show("Please select a valid color"); } }
        }

        public MyButton()
        {
            InitializeComponent();
            this.MouseDown += MyButton_MouseDown;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            DrawButton(Color.FromKnownColor(KnownColor.Control));
        }

        private void DrawButton(Color c)
        {
            //SolidBrush s = new SolidBrush(Color.FromKnownColor(KnownColor.Control));
            var s = new SolidBrush(c);
            Graphics g = this.CreateGraphics();
            g.FillRectangle(s, 0, 0, this.Width, this.Height);
            //s.Color = Color.FromKnownColor(KnownColor.ControlLight);
            s.Color = Color.FromArgb(255, c.R - 13, c.G - 13, c.B - 13);
            g.FillRectangle(s, 0, this.Height / 2, this.Width, this.Height / 2);
            PointF fpoint = new Point((this.Width / 2) - (text.Length / 2), (this.Height / 2) - (text.Length));

            FontFamily fontFamily = new FontFamily("Arial");
            Font f = new Font(fontFamily, 8);
            s.Color = Color.Black;
            g.DrawString(text, f, s, fpoint);
        }

        private void MyButton_MouseHover(object sender, System.EventArgs e)
        {
            var knownColor = Color.FromKnownColor(KnownColor.Control);
            var color = Color.FromArgb(255, knownColor.R - 30, knownColor.R - 5, 255);
            DrawButton(color);
        }

        private void MyButton_MouseLeave(object sender, System.EventArgs e)
        {
            DrawButton(buttonColor);
        }

        private void MyButton_MouseDown(object sender, System.EventArgs e)
        {
            var kColor = Color.FromKnownColor(KnownColor.Control);
            Color color = Color.FromArgb(255, kColor.R + 15, kColor.G - 15, 150);
            DrawButton(color);
        }
    }
}