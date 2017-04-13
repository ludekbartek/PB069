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
using System.Windows.Shapes;

namespace WPFLayoutsDemo
{
    /// <summary>
    /// Interaction logic for AddDialog.xaml
    /// </summary>
    public partial class AddDialog : Window
    {
        public AddDialog()
        {
            InitializeComponent();
        }

        private void Dialog_OK_Click(object sender, RoutedEventArgs e)
        {
            if(input.Text!="" && input2.Text!="")
            {
                DialogResult = true;
                return;
            }
            DialogResult = false;
        }
    }
}
