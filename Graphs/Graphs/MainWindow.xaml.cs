using System;
using System.Collections.Generic;
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

namespace Graphs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        

        public delegate double FunctionDelegate(double x);
        private static FunctionDelegate sinDelegate = Math.Sin, cosDelegate = Math.Cos;



        public int CoefAProperty
        {
            get { return (int)GetValue(CoefAPropertyProperty); }
            set { SetValue(CoefAPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CoefAProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CoefAPropertyProperty =
            DependencyProperty.Register("CoefAProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0,PropertyChanged));

        private static void PropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MainWindow win = (MainWindow)d;
            DrawGraph(win);
        }

        public int CoefBProperty
        {
            get { return (int)GetValue(CoefBPropertyProperty); }
            set { SetValue(CoefBPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CoefBProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CoefBPropertyProperty =
            DependencyProperty.Register("CoefBProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0,PropertyChanged));

        
        public FunctionDelegate FuncProperty
        {
            get { return (FunctionDelegate)GetValue(FuncPropertyProperty); }
            set { SetValue(FuncPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FuncProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FuncPropertyProperty =
            DependencyProperty.Register("FuncProperty", typeof(FunctionDelegate), typeof(MainWindow), new PropertyMetadata(sinDelegate,PropertyChanged));

        

        private static void DrawGraph(MainWindow win)
        {
            win.DrawArea.Children.Clear();
            DrawAxes(win);
            DrawFunction(win);
        }

        private static void DrawFunction(MainWindow win)
        {
            Polyline funcGraph = new Polyline();
            funcGraph.Stroke = Brushes.Black;
            double width = win.DrawArea.ActualWidth;
            for (int i=1 ; i < width ; i++)
            {
                double x = ConvertX(win.DrawArea,i);
                double value = win.CoefAProperty * win.FuncProperty(win.CoefBProperty * x);
                double Y = ConvertY(win.DrawArea,value);
                funcGraph.Points.Add(new Point(i, Y));
            }
            win.DrawArea.Children.Add(funcGraph);
        }

        private static double ConvertY(Canvas canvas,double value)
        {
            double scale = canvas.ActualHeight/5.0;
            return canvas.ActualHeight / 2 - scale * value;

        }

        private static double ConvertX(Canvas canvas, int i)
        {
            double step =  4 * Math.PI / canvas.ActualWidth;
            return i * step;
        }

        private static void DrawAxes(MainWindow win)
        {
            double width = win.DrawArea.ActualWidth,
                   height = win.DrawArea.ActualHeight,
                   heightHalf = height / 2,
                   widthHalf = width / 2;

            DrawLine(win.DrawArea,0, heightHalf, width, heightHalf,Brushes.Red);
            DrawLine(win.DrawArea,widthHalf, 0, widthHalf, height, Brushes.Red);
        }

        private static void DrawLine(Canvas area,double x1, double y1, double x2, double y2, SolidColorBrush color)
        {
            Line line = new Line();
            line.Stroke = color;
            line.X1 = x1;
            line.Y1 = y1;
            line.X2 = x2;
            line.Y2 = y2;
            area.Children.Add(line);
        }

        public MainWindow()
        {
            InitializeComponent();
            for(int i = -2; i < 0; i++)
            {
                CoefABox.Items.Add(i);
            }
            for(int i = 1; i <= 2; i++)
            {
                CoefABox.Items.Add(i);
            }
            for(int i = -3; i < 0; i++)
            {
                CoefBBox.Items.Add(i);
            }
            for(int i = 1; i <= 3; i++)
            {
                CoefBBox.Items.Add(i);
            }
            
            ComboBoxItem sinItem = new ComboBoxItem(),
                         cosItem = new ComboBoxItem();
            sinItem.Content = "Sin";
            sinItem.Tag = sinDelegate;
            cosItem.Content = "Cos";
            cosItem.Tag = cosDelegate;
            FuncBox.Items.Add(sinItem);
            FuncBox.Items.Add(cosItem);
            DrawAxes(this);
        }

        private void CoefABox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CoefAProperty = (int)CoefABox.SelectedValue;
        }

        private void FuncBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FunctionDelegate sin = Math.Sin, cos = Math.Cos;
            FuncProperty = (FuncBox.SelectedIndex==0 ? sin : cos);
        }

        private void CoefBBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CoefBProperty = (int)CoefBBox.SelectedValue;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
