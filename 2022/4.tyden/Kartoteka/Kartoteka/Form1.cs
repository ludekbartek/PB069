namespace Kartoteka
{
    public enum Shapes
    {
        LINE, RECTANGLE, ELLIPSE
    }
    public partial class Form1 : Form
    {
        private Shapes current = Shapes.LINE;
        private Shape curShape = null;
        private List<Shape> drawn = new List<Shape>();
        public Form1()
        {
            InitializeComponent();
        }

        private void caraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAll();
            caraToolStripMenuItem.Checked = true;
            current = Shapes.LINE;  
        }

        private void UncheckAll()
        {
            caraToolStripMenuItem.Checked = false;
            kruhToolStripMenuItem.Checked = false;  
            obdelnikToolStripMenuItem.Checked = false; 
        }

        private void kruhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAll();
            kruhToolStripMenuItem.Checked = true;
            current = Shapes.ELLIPSE;
        }

        private void obdelnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAll();
            obdelnikToolStripMenuItem.Checked = true;
            current = Shapes.RECTANGLE;
        }

        private void novyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawn.Clear();
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            foreach (Shape shape in drawn)
            {
                drawShape(shape, e.Graphics);
            }
        }

        private void drawShape(Shape shape, Graphics graphics)
        {
            switch (shape.Type)
            {
                case Shapes.LINE:
                    graphics.DrawLine(Pens.Black, shape.X, shape.Y, shape.X+shape.DX, shape.Y + shape.DY);
                    break;
                case Shapes.RECTANGLE:
                    graphics.DrawRectangle(Pens.Black, shape.X, shape.Y, shape.DX, shape.DY);
                    break;
                case Shapes.ELLIPSE:
                    graphics.DrawEllipse(Pens.Black, shape.X,shape.Y, shape.DX, shape.DY);
                    break;
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            curShape = new Shape();
            curShape.X = e.X;
            curShape.Y = e.Y;
            curShape.Type = current;
            drawn.Add(curShape);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (drawn != null && drawn.Count > 0 && curShape!=null)
            {
                Shape shape = drawn.Last<Shape>();


                if (e.X > shape.X)
                {
                    shape.DX = e.X - shape.X;
                }
                else
                {
                    shape.DX = shape.X - e.X;
                    shape.X = e.X;
                }
                if (e.Y > shape.Y)
                {
                    shape.DY = e.Y - shape.Y;
                }
                else
                {
                    shape.DY = shape.Y - e.Y;
                    shape.Y = e.Y;
                }
                Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawn.Count > 0)
            {
                Shape cur = drawn.Last<Shape>();
                int dx = e.X - cur.X;
                if (dx > 0)
                {
                    cur.DX = dx;
                }
                else
                {
                    cur.X = e.X;
                    cur.DX = -dx;
                }
            }
            curShape = null;
            Update();
        }
    }

    public class Shape
    {
        public Shapes Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int DX { get; set; }
        public int DY { get; set; }

        public override string ToString()
        {
            return String.Format("{0};{1};{2};{3};{4}",(int)Type,X,Y,DX, DY);  
        }

        public static Shape Parse(String text)
        {
            Shape shape = new Shape();
            string[] parts = text.Split(';', 3);
            if(parts.Length != 5)
            {
                throw new Exception("Invalid file format");
            }
            shape.Type = (Shapes)int.Parse(parts[0]); 
            shape.X = int.Parse(parts[1]);
            shape.Y = int.Parse(parts[2]);
            shape.DX = int.Parse(parts[3]);
            shape.DY = int.Parse(parts[4]);
            return shape;
        }

    }
}