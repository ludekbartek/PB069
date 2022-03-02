namespace SimpleGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            var dx = int.Parse(dxTextBox.Text);
            var dy = int.Parse(dyTextBox.Text);
            var x = e.Location.X;
            var y = e.Location.Y;
            using (Graphics g = Graphics.FromHwnd(pictureBox1.Handle))
            {
                switch (shapeComboBox.SelectedIndex)
                {
                    case 0: g.DrawLine(Pens.Black, x, y, x + dx, y + dy);
                        break;
                    case 1: g.DrawRectangle(Pens.Black, x,y, dx, dy);
                        break;
                    case 2: g.DrawEllipse(Pens.Black, x, y, dx, dy);
                        break;

                }
            }
        }
    }
}