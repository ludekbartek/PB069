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

namespace DataBank_DB
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

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if(title.Text == "" || director.Text =="" || DataPicker.DisplayDate == null)
            {
                return;
            }

            medium = new Medium();
            medium.title = title.Text;
            medium.year = DataPicker.DisplayDate;
            medium.director = director.Text;
            DialogResult = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            return;
        }
    }
}
