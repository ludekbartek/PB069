namespace Draw2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void novyToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Graphics g = Graphics.FromImage(pictureBox1.Image)) {
                g.Clear(Color.White);
            }
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}