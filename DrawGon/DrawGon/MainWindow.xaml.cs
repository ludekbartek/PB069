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

namespace DrawGon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for(int i = -3; i < 0; i++)
            {
                ACombo.Items.Add(i);
            }
            for(int i = 1; i <= 3; i++)
            {
                ACombo.Items.Add(i);
                BCombo.Items.Add(i);
            }
        }



        public int CoefAProperty
        {
            get { return (int)GetValue(CoefAPropertyProperty); }
            set { SetValue(CoefAPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CoefAProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CoefAPropertyProperty =
            DependencyProperty.Register("CoefAProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(ValuesChanged)));



        public int CoefBProperty
        {
            get { return (int)GetValue(CoefBPropertyProperty); }
            set { SetValue(CoefBPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CoefBProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CoefBPropertyProperty =
            DependencyProperty.Register("CoefBProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0, new PropertyChangedCallback(ValuesChanged)));





        public string FunctionProperty
        {
            get { return (string)GetValue(FunctionPropertyProperty); }
            set { SetValue(FunctionPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FunctionProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FunctionPropertyProperty =
            DependencyProperty.Register("FunctionProperty", typeof(string), typeof(MainWindow), new PropertyMetadata(0,new PropertyChangedCallback(ValuesChanged)));



        private static void ValuesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Console.WriteLine("Property has changed");
        }

        private void ACombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ACombo.SelectedIndex >=0)
            {
                CoefAProperty = (int)ACombo.SelectedValue;
            }
        }
    }
}
