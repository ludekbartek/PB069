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

namespace GraphDraw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        delegate double function(double value);
        public MainWindow()
        {
            InitializeComponent();
            for (int i = -3; i < 0; i++)
            {
                aBox.Items.Add(i);
            }
            for(int i = 1; i <= 3; i++)
            {
                aBox.Items.Add(i);
                bBox.Items.Add(i);
            }
            aBox.SelectedItem = 1;
            bBox.SelectedIndex = 0;
            canvas.Height = this.Height - 100;
            canvas.Width = this.Width-20;

        }



        public int CoefA
        {
            get { return (int)GetValue(CoefAProperty); }
            set { SetValue(CoefAProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CoefA.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CoefAProperty =
            DependencyProperty.Register("CoefA", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(ValuesChanged)));



        public int CoefB
        {
            get { return (int)GetValue(CoefBProperty); }
            set { SetValue(CoefBProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CoefB.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CoefBProperty =
            DependencyProperty.Register("CoefB", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(ValuesChanged)));




        public int Function
        {
            get { return (int)GetValue(FunctionProperty); }
            set { SetValue(FunctionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Function.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FunctionProperty =
            DependencyProperty.Register("Function", typeof(int), typeof(MainWindow), new PropertyMetadata(0,new PropertyChangedCallback(ValuesChanged)));


        private static void ValuesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MainWindow win = d as MainWindow;
            Refresh(win);
        }

        private static void Refresh(MainWindow win)
        {
            win.canvas.Children.Clear();
            drawAxes(win.canvas);
            if(win.aBox.SelectedIndex <0 || win.bBox.SelectedIndex <0 || win.fceBox.SelectedIndex < 0)
            {
                return;
            }
            double a = (int)win.aBox.SelectedValue;
            double b = (int)win.bBox.SelectedValue;
            function func;
            if (win.fceBox.SelectedIndex == 0)
            {
                drawFunction(win.canvas,win.canvas.Width, a, Math.Sin, b);
            }
            else
            {
                drawFunction(win.canvas,win.canvas.Width, a, Math.Cos, b);
            }
            
        }

        private static void drawAxes(Canvas canvas)
        {
            if(canvas.Height!= canvas.Height || canvas.Width != canvas.Width)
            {
                return;
            }
            Line axeX = new Line();
            axeX.Stroke = Brushes.Red;
            axeX.X1 = 0;
            axeX.X2 = canvas.Width;
            axeX.Y1 = canvas.Height / 2;
            axeX.Y2 = canvas.Height / 2;
            canvas.Children.Add(axeX);
            Line axeY = new Line();
            axeY.Stroke = Brushes.Red;
            axeY.X1 = canvas.Width / 2;
            axeY.X2 = canvas.Width / 2;
            axeY.Y1 = 0;
            axeY.Y2 = canvas.Height;
            canvas.Children.Add(axeY);
           
        }

        private static void drawFunction(Canvas canvas, double width,double a, function func, double b)
        {
            Polyline line = new Polyline();
            line.Stroke = Brushes.Black;
            for(int i=0;i< width; i++)
            {
                double x = convertCanvasToReal(width, i);
                double yRes = a * func(b * x);
                int y = convertRealToCanvas(canvas.Height, yRes);
                Point point = new Point(i, y);
                line.Points.Add(point);
            }
            canvas.Children.Add(line);
        }

        private static double convertCanvasToReal(double width, int i)
        {
            double x = (4 * Math.PI / width) * i;
            return x - 2*Math.PI;
        }

        private static int convertRealToCanvas(double height, double yRes)
        {
            double y = yRes * (height / 7);
            return (int)(height/2 - y);
        }

        private void newMenuItem_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
        }

       
        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void fceBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Function = fceBox.SelectedIndex;
        }

        private void aBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CoefA = (int)aBox.SelectedItem;
        }

        private void bBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CoefB = (int)bBox.SelectedItem;
        }
    }
}

