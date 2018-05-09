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

namespace WPFDependencyProperties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate double ComboItemDelegate(double param);



        public int CoefA
        {
            get { return (int)GetValue(CoefAProperty); }
            set { SetValue(CoefAProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CoefA.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CoefAProperty =
            DependencyProperty.Register("CoefA", typeof(int), typeof(MainWindow), new PropertyMetadata(0,CoefAChanged));

        private static void CoefAChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MainWindow win = (MainWindow)d;
            refreshGraph(win);
        }



        public int CoefB
        {
            get { return (int)GetValue(CoefBProperty); }
            set { SetValue(CoefBProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CoefB.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CoefBProperty =
            DependencyProperty.Register("CoefB", typeof(int), typeof(MainWindow), new PropertyMetadata(0,CoefBChanged));

        private static void CoefBChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MainWindow win = (MainWindow)d;
            refreshGraph(win);
        }

        public ComboItemDelegate FunctionProperty
        {
            get { return (ComboItemDelegate)GetValue(FunctionPropertyProperty); }
            set { SetValue(FunctionPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FunctionProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FunctionPropertyProperty =
            DependencyProperty.Register("FunctionProperty", typeof(ComboItemDelegate), typeof(MainWindow), new PropertyMetadata((ComboItemDelegate)Math.Sin ,FunctionPropertyChanged));

        private static void FunctionPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MainWindow win = (MainWindow)d;
            refreshGraph(win);
        }

        private static void refreshGraph(MainWindow win)
        {
            Canvas canvas = win.DrawArea;
            canvas.Children.Clear();
            double height = win.DrawArea.ActualHeight;
            double width = win.DrawArea.ActualWidth;
            double angleStep = 4 * Math.PI / width;
            drawAxes(win);
            double lastX = 0;
            double lastY = win.CoefA * win.FunctionProperty(-2 * Math.PI * win.CoefB);
            for(int i = 1; i < width; i++)
            {
               
                double x = -2 * Math.PI + i * angleStep;
                ComboItemDelegate function = win.FunctionProperty;
                double value = (height/2) * win.CoefA * function(x * win.CoefB);
                double y = height / 2 - value;
                Line line = new Line();
                line.Stroke = Brushes.Black;
                line.X1 = i;
                line.Y1 = lastY;
                line.X2 = i+1;
                line.Y2 = y;
                canvas.Children.Add(line);
                lastX = i+1;
                lastY = y;
            }
        }

        private static void drawAxes(MainWindow win)
        {
            Line axeX = new Line();
            axeX.Stroke = Brushes.Red;
            axeX.X1 = 0;
            axeX.X2 = win.DrawArea.ActualWidth;
            axeX.Y1 = win.DrawArea.ActualHeight / 2;
            axeX.Y2 = axeX.Y1;
            win.DrawArea.Children.Add(axeX);
            Line axeY = new Line();
            axeY.Stroke = Brushes.Red;
            axeY.X1 = win.Width / 2;
            axeY.X2 = axeY.X1;
            axeY.Y1 = 0;
            axeY.Y2 = win.DrawArea.ActualHeight;
            win.DrawArea.Children.Add(axeY);

        }

        public MainWindow()
        {
            InitializeComponent();
            for(int i = -10; i < 0; i++)
            {
                ABox.Items.Add(i);
            }
            for(int i = 1; i <= 10; i++)
            {
                ABox.Items.Add(i);
                BBox.Items.Add(i);
                if (i == 1)
                {
                    ABox.SelectedIndex = 10 + i;
                    BBox.SelectedIndex = 10 + i;
                }
            }
           /* ABox.SelectedItem = 1;
            BBox.SelectedItem = 1;*/
            ComboItemDelegate sin = Math.Sin;
            ComboItemDelegate cos = Math.Cos;
            ComboBoxItem sinItem = new ComboBoxItem();
            sinItem.Tag = sin;
            sinItem.Content = "Sin";
            ComboBoxItem cosItem = new ComboBoxItem();
            cosItem.Tag = cos;
            cosItem.Content = "Cos";
            FunBox.Items.Add(sinItem);
            FunBox.Items.Add(cosItem);
            FunBox.SelectedIndex = 0;
        }

        private void ABox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CoefA = (int)ABox.SelectedItem;
        }

        private void FunBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboItemDelegate sin = Math.Sin, cos = Math.Cos;
            FunctionProperty = (FunBox.SelectedIndex == 0 ? sin : cos);
        }

        private void BBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CoefB = (int)BBox.SelectedItem;
        }
    }
}
