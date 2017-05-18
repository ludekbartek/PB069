using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace DataBinding
{
    public class Person:INotifyPropertyChanged
    {
        private string name; 
        private uint age;
      
        public string Name
        {
            get { return this.name; }
            set { this.name = value;
                Notify("Name");
            }
        }

        public uint Age
        {
            get { return this.age; }
            set
            {
                this.age = value;
                Notify("Age");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void Notify(string propName)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }

        }
        public override string ToString()
        {
            return name + "(" + age + ")";
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> people;
        private Person selectedPerson = new Person();
        public MainWindow()
        {
            InitializeComponent();
            people = new ObservableCollection<Person>();
            selectedPerson.PropertyChanged += selectedPersonPropertyChanged;
            
            Person a = new Person();
            a.Name = "Jan Novak";
            a.Age = 20;
            a.PropertyChanged += selectedPersonPropertyChanged;
            people.Add(a);
            PeopleView.ItemsSource = people;
            //PeopleView.SelectedItem = a;
        }

        private void selectedPersonPropertyChanged(object source, PropertyChangedEventArgs args)
        {
            switch(args.PropertyName)
            {
                case "Name":NameBox.Text = selectedPerson.Name;
                    break;
                case "Age":AgeSlider.Value = selectedPerson.Age;
                    break;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void PeopleView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedPerson.Name = ((Person)PeopleView.SelectedItem).Name;
            selectedPerson.Age = ((Person)PeopleView.SelectedItem).Age;
            
        }

        private void AgeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (PeopleView.SelectedIndex >= 0)
            {
                selectedPerson.Age = (uint)AgeSlider.Value;
                Console.WriteLine(selectedPerson.Age);
                ((Person)PeopleView.SelectedItem).Age = (uint)AgeSlider.Value;
                //AgeBox.Text = AgeSlider.Value.ToString();
            }
        }

        private void NameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            selectedPerson.Name = NameBox.Text;
            ((Person)PeopleView.SelectedItem).Name = NameBox.Text;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            AddPerson dialog = new AddPerson();
            if (dialog.ShowDialog() == true)
            {
                people.Add(dialog.person);
            } 

        }
    }
}
