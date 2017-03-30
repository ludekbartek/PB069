using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartoteka_drag_n_drop
{
    public partial class ObjectDisplay : Form
    {
        public ObjectDisplay()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ObjectDisplay_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data != null)
            {
                ShowObject((GraphicalObject)e.Data,e.X - pictureBox1.Location.X,e.Y - pictureBox1.Location.Y);
            }
        }

        private void ShowObject(GraphicalObject data, int x, int y)
        {
            using (Graphics g = pictureBox1.CreateGraphics())
            {
                drawObject(g, data, x, y);
            }
        }

        private void drawObject(Graphics g, GraphicalObject data,int x, int y)
        {
            switch(data.type)
            {
                case ObjectType.LINE:
                    g.DrawLine(Pens.Black, x, y, x + data.dx, y + data.dy);
                    break;
                case ObjectType.RECTANGLE:
                    g.DrawRectangle(Pens.Black, x, y, data.dx, data.dy);
                    break;
                case ObjectType.CIRCLE:
                    g.DrawEllipse(Pens.Black, x, y, data.dx, data.dy);
                    break;
                default:
                    break;
            }
           // Refresh();
        }

        private void ObjectDisplay_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
