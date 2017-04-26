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

namespace DataBank
{
    /// <summary>
    /// Interaction logic for AddMedium.xaml
    /// </summary>
    public partial class AddMedium : Window
    {
        public Medium medium { get; set; }
        public AddMedium()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            if (title1.Text == "" || title2.Text == "" || title3.Text == "")
                return;
            DialogResult = true;
            medium = new Medium();
            medium.title1 = title1.Text;
            medium.title2 = title2.Text;
            medium.title3 = title3.Text;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
