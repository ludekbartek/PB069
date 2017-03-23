using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionsDrawing
{
    public partial class Form1 : Form
    {
        private List<Function> functions = new List<Function>();

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearImage(pictureBox1.Image);
            functions = new List<Function>();
        }

        private void clearImage(Image image)
        {
            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }
            using (Graphics g = Graphics.FromImage(image))
            {
                g.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height);
                drawAxes(g,pictureBox1.Width,pictureBox1.Height);
            }
            pictureBox1.Refresh();
        }

        private void drawAxes(Graphics g, int width,int height)
        {
            g.DrawLine(Pens.Black, 0, height / 2, width, height / 2);
            g.DrawLine(Pens.Black, width / 2, 0, width / 2, height);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFunction dialog = new AddFunction();
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                functions.Add(dialog.function);
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
                drawAxes(e.Graphics, pictureBox1.Width, pictureBox1.Height);
                foreach (Function func in functions)
                {
                    drawFunction(e.Graphics, func);
                }
        }

        private void drawFunction(Graphics graphics, Function func)
        {
            if(func.function == Kind.sin)
            {
                drawSin(graphics, func);
            }
            else
            {
                drawCos(graphics, func);
            }
        }

        private void drawSin(Graphics graphics, Function func)
        {
            double stepX = 4 * Math.PI / pictureBox1.Width;
            double coefY = pictureBox1.Height / 10;
            double x = -2*Math.PI;
            int lastY = pictureBox1.Height / 2; 
            for(int i=1;i<pictureBox1.Width;i++)
            {
                x += stepX;
                double y = func.a * Math.Sin(func.f * x);
                int yCoord = (int)(pictureBox1.Height / 2 - coefY * y);
                graphics.DrawLine(Pens.Black, i - 1, lastY, i, yCoord);
                lastY = yCoord;
                
            }

        }

        private void drawCos(Graphics graphics, Function func)
        {
            double stepX = 4 * Math.PI / pictureBox1.Width;
            double coefY = pictureBox1.Height / 10;
            double x = -2 * Math.PI;
            double yValue = func.a * Math.Cos(func.f * -2 * Math.PI);
            int lastY = (int)(pictureBox1.Height / 2 - coefY * yValue);
            for (int i = 1; i < pictureBox1.Width; i++)
            {
                x += stepX;
                double y = func.a * Math.Cos(func.f * x);
                int yCoord = (int)(pictureBox1.Height / 2 - coefY * y);
                graphics.DrawLine(Pens.Black, i - 1, lastY, i, yCoord);
                lastY = yCoord;

            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "CSV (*.csv)|*.csv";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                saveData(saveFileDialog1.FileName);
            }
        }

        private void saveData(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach(Function func in functions)
                {
                    writer.WriteLine(func);
                }
            }
        }

        private void otevřítToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                loadData(openFileDialog1.FileName);
            }
        }

        private void loadData(string fileName)
        {
            functions.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Function func = line2Function(line);
                    functions.Add(func);
                    line = reader.ReadLine();
                }
            }
            clearImage(pictureBox1.Image);
            pictureBox1.Refresh();
        }

        private Function line2Function(string line)
        {
            string[] parts = line.Split(';');
            if (parts.Length != 3)
            {
                throw new InvalidDataException("The line format is wrong: " + line);
            }
            Function func = new Function();
            func.function=(Kind)(Int16.Parse(parts[0]));
            func.a = Int16.Parse(parts[1]);
            func.f = Int16.Parse(parts[2]);
            return func;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Jpeg (*.jpg)|*.jpg";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    drawAxes(g, pictureBox1.Width, pictureBox1.Height);
                    foreach (Function f in functions)
                    {
                        drawFunction(g, f);
                    }
                }
                pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
            }

        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
