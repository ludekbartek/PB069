using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GraphicalEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<GraphicalObject> objects = new List<GraphicalObject>(); 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewMenuItem_Click(object sender, RoutedEventArgs e)
        {
            objects.Clear();
            this.Refresh(PaintCanvas);
        }

        private void Refresh(Canvas paintCanvas)
        {
            paintCanvas.Children.Clear();
            foreach(GraphicalObject obj in objects)
            {
                Draw(obj, paintCanvas);
            }
        }

        private void Draw(GraphicalObject obj, Canvas paintCanvas)
        {
            switch(obj.type)
            {
                case ObjectType.Line:
                    DrawLine(obj, paintCanvas);
                    break;
                case ObjectType.Rectangle:
                    DrawRectangle(obj, paintCanvas);
                    break;
                case ObjectType.Ellipse:
                    DrawEllipse(obj, paintCanvas);
                    break;
            }
        }

        private void DrawEllipse(GraphicalObject obj, Canvas paintCanvas)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = obj.dx;
            ellipse.Height = obj.dy;
            ellipse.Stroke = Brushes.Black;
            paintCanvas.Children.Add(ellipse);
            Canvas.SetTop(ellipse, obj.X);
            Canvas.SetLeft(ellipse, obj.Y);
        }

        private void DrawRectangle(GraphicalObject obj, Canvas paintCanvas)
        {
            Polygon rect = new Polygon();
            Point p1 = new Point(),p2 = new Point(), p3 = new Point(),p4 = new Point();
            p1.X = obj.X;
            p1.Y = obj.Y;
            p2.X = obj.X + obj.dx;
            p2.Y = obj.Y;
            p3.X = p2.X;
            p3.Y = obj.Y + obj.dy;
            p4.X = obj.X;
            p4.Y = obj.Y + obj.dy;
            rect.Points.Add(p1);
            rect.Points.Add(p2);
            rect.Points.Add(p3);
            rect.Points.Add(p4);
            rect.Points.Add(p1);
            rect.Stroke = Brushes.Black;
            paintCanvas.Children.Add(rect);
            
        }

        private void DrawLine(GraphicalObject obj, Canvas paintCanvas)
        {
            Line line = new Line();
            line.X1 = obj.X;
            line.Y1 = obj.Y;
            line.X2 = obj.X + obj.dx;
            line.Y2 = obj.Y + obj.dy;
            line.Stroke = Brushes.Black;
            paintCanvas.Children.Add(line);
        }

        private void OpenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                objects.Clear();
                LoadData(dialog.FileName);
                Refresh(PaintCanvas);
            }
        }

        private void LoadData(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    GraphicalObject obj = GraphicalObject.ParseObject(line);
                    objects.Add(obj);
                }
            }
        }

        private void SaveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == true)
            {
                SaveData(dialog.FileName);
            }
        }

        private void SaveData(string filename)
        {
            using(StreamWriter writer = new StreamWriter(filename))
            {
                foreach(GraphicalObject obj in objects)
                {
                    writer.WriteLine(obj);
                }
            }
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LineMenuItem_Click(object sender, RoutedEventArgs e)
        {
            GraphicalObject obj = new GraphicalObject();
            obj.type = ObjectType.Line;
            AddObjectDialog dialog = new AddObjectDialog();
            dialog.GraphicalObject = obj;
            if (dialog.ShowDialog() == true)
            {
                objects.Add(dialog.GraphicalObject);
                Refresh(PaintCanvas);
            }
        }

        private void RectangleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            GraphicalObject obj = new GraphicalObject();
            obj.type = ObjectType.Rectangle;
            AddObjectDialog dialog = new AddObjectDialog();
            dialog.GraphicalObject = obj;
            if (dialog.ShowDialog() == true)
            {
                objects.Add(dialog.GraphicalObject);
                Refresh(PaintCanvas);
            }
        }

        private void EllipseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            GraphicalObject obj = new GraphicalObject();
            obj.type = ObjectType.Ellipse;
            AddObjectDialog dialog = new AddObjectDialog();
            dialog.GraphicalObject = obj;
            if (dialog.ShowDialog() == true)
            {
                objects.Add(dialog.GraphicalObject);
                Refresh(PaintCanvas);
            }

        }

    }
}
