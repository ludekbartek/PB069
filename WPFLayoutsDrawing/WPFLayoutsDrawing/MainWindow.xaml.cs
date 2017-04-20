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

namespace WPFLayoutsDrawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public enum COLORS { RED, GREEN, BLUE, BLACK };

    public class MyShape
    {
        public double x { get; set; }
        public double y { get; set; }
        public double dx { get; set; }
        public double dy { get; set; }
        public int kind { get; set; }
        public COLORS color { get; set; }
        
        public override string ToString()
        {
            return $"{kind};{x};{y};{dx};{dy};{(int)color}";
        }
    }
    public partial class MainWindow : Window
    {
        private List<MyShape> shapes = new List<MyShape>();
        private Shape currentShape;
        private Brush color = Brushes.Black;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ClearDataAndCanvas();
        }

        private void ClearDataAndCanvas()
        {
            Canvas.Children.Clear();
            shapes.Clear();
        }

        private void OpenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                loadShapes(dialog.FileName);
            }
        }

        private void loadShapes(string fileName)
        {
            MyShape shape;
            ClearDataAndCanvas();
            using (StreamReader reader = new StreamReader(fileName))
            {
                String line;
                while ((line = reader.ReadLine()) != null)
                {
                    shape = lineToShape(line);
                    shapes.Add(shape);

                    drawShape(shape);
                }
            }
        }

        private void drawShape(MyShape shape)
        {
            Shape current = null;
            if (shape.kind == 0)
            {
                current = new Rectangle();
            }
            else
            {
                current = new Ellipse();
            }
            current.Width = shape.dx;
            current.Height = shape.dy;
            switch (shape.color)
            {
                case COLORS.RED:
                    current.Stroke = Brushes.Red;
                    break;
                case COLORS.GREEN:
                    current.Stroke = Brushes.Green;
                    break;
                case COLORS.BLUE:
                    current.Stroke = Brushes.Blue;
                    break;
                default:
                    current.Stroke = Brushes.Black;
                    break;
               
            }
            Canvas.Children.Add(current);
            Canvas.SetTop(current, shape.y);
            Canvas.SetLeft(current, shape.x);
        }

        private MyShape lineToShape(string line)
        {
            MyShape shape = new MyShape();
            String[] parts = line.Split( new char[] { ';' },6);

            if (parts.Length != 6)
            {
                throw new InvalidDataException("File format is wrong.");
            }
            int type = int.Parse(parts[0]);
            
            double x, y, dx, dy;
            x = Double.Parse(parts[1]);
            y = Double.Parse(parts[2]);
            dx = Double.Parse(parts[3]);
            dy = Double.Parse(parts[4]);
            
            COLORS color = (COLORS)int.Parse(parts[5]);
            shape.kind = type;
            shape.x = x;
            shape.y = y;
            shape.dx = dx;
            shape.dy = dy;
            shape.color = color;
            
            return shape;

        }

        private void SaveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if(dialog.ShowDialog()==true)
            {
                saveShapes(dialog.FileName);
            }
        }

        private void saveShapes(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (MyShape shape in shapes)
                {
                    writer.WriteLine(shape);
                }
            }
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

        private void LineMenuItem_Click(object sender, RoutedEventArgs e)
        {
            LineMenuItem.IsChecked = true;
            CircleMenuItem.IsChecked = false;
            currentShape = new Rectangle();
            currentShape.Stroke = (color==null ? Brushes.Black : color);
        }

        private void CircleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CircleMenuItem.IsChecked = true;
            LineMenuItem.IsChecked = false;
            currentShape = new Ellipse();
            currentShape.Stroke = (color==null ? Brushes.Black : color);
            
        }

        
        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (currentShape != null)
            {
                currentShape.Stroke = color;
                Canvas.Children.Add(currentShape);
                Point position = e.GetPosition(Canvas);
                Canvas.SetLeft(currentShape, position.X);
                Canvas.SetTop(currentShape, position.Y);
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentShape != null)
            {
                double x = Canvas.GetLeft(currentShape);
                double y = Canvas.GetTop(currentShape);
                Point pos = e.GetPosition(Canvas);
                currentShape.Width = Math.Abs(pos.X - x);
                currentShape.Height = Math.Abs(pos.Y - y);
            }
        }

        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (currentShape != null)
            {
                MyShape shape = new MyShape();
                shape.kind = (currentShape is Rectangle ? 0 : 1);
                shape.x = Canvas.GetLeft(currentShape);
                shape.y = Canvas.GetTop(currentShape);
                shape.dx = currentShape.Width;
                shape.dy = currentShape.Height;
                shape.color = BrushToCOLOR(color);
                shapes.Add(shape);
                currentShape = null;
            }
        }

        private COLORS BrushToCOLOR(Brush color)
        {
            if(color == Brushes.Red)
            {
                    return COLORS.RED;
            }
            if(color ==  Brushes.Green)
            {
                return COLORS.GREEN;
            }
            if(color == Brushes.Blue)
            {
                return COLORS.BLUE;
            }
            return COLORS.BLACK;
        }

        
        private void ColorBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ColorBox.SelectedItem == RedBoxItem)
            {
                color = Brushes.Red;
            }
            if (ColorBox.SelectedItem == GreeBoxItem)
            {
                color = Brushes.Green;
            }
            if (ColorBox.SelectedItem == BlueBoxItem)
            {
                color = Brushes.Blue;
            }
            if (ColorBox.SelectedItem == BlackBoxItem)
            {
                color = Brushes.Black;
            }
            if (currentShape != null)
            {
                currentShape.Stroke = color;
            }
        }
    }
}
