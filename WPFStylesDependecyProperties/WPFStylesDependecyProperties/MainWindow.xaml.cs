using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPFStylesDependecyProperties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> PeopleList { get; set; }
        public MainWindow()
        {


            InitializeComponent();
            PeopleList = new ObservableCollection<Person>();
            PeopleView.ItemsSource = PeopleList;
            Person john = new Person();
            john.Name = "Jan";
            john.Surname = "Novak";
            PeopleList.Add(john);
        }

        private void AddBox_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddItemDialog dialog = new AddItemDialog();
            if(dialog.ShowDialog() == true)
            {
                PeopleList.Add(dialog.Person);
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if(PeopleView.SelectedIndex != -1)
            {
                PeopleList.RemoveAt(PeopleView.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Nutno zvolit odebiranou osubku.");
            }
        }
    }
}
