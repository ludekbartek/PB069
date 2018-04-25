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

namespace GraphicalEditor
{
    /// <summary>
    /// Interaction logic for AddObjectDialog.xaml
    /// </summary>
    public partial class AddObjectDialog : Window
    {
        public GraphicalObject GraphicalObject { get; set; }

        public AddObjectDialog()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckInputs())
            {
                GraphicalObject.X = int.Parse(XBox.Text);
                GraphicalObject.Y = int.Parse(YBox.Text);
                GraphicalObject.dx = int.Parse(DXBox.Text);
                GraphicalObject.dy = int.Parse(DYBox.Text);
                DialogResult = true;
            }
        }

        private bool CheckInputs()
        {
            return XBox.Text != "" && YBox.Text != "" && DXBox.Text != "" && DYBox.Text != "";
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
