using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace DataBank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Medium> media = new ObservableCollection<Medium>(); 
        public MainWindow()
        {
            InitializeComponent();
            DataView.ItemsSource = media;
        }

        private void OpenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog()== true)
            {
                media.Clear();
                using (StreamReader reader = new StreamReader(dialog.FileName))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        Medium medium = lineToMedium(line);
                        media.Add(medium);
                        line = reader.ReadLine();
                    }
                }
            }

        }

        private Medium lineToMedium(string line)
        {
            string[] parts = line.Split(';');
            if (parts.Length != 4)
            {
                throw new InvalidDataException("Invalid file format.");
            }
            Medium medium = new Medium();
            int id = int.Parse(parts[0]);
            medium.id = id;
            medium.title1 = parts[1];
            medium.title2 = parts[2];
            medium.title3 = parts[3];
            return medium;
        }

        private void NewMenuItem_Click(object sender, RoutedEventArgs e)
        {
            media.Clear();
        }

        private void SaveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == true)
            {
                using (StreamWriter writer = new StreamWriter(dialog.FileName))
                {
                    foreach (Medium medium in media)
                    {
                        writer.WriteLine(medium);
                    }
                }
            }
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

        private void AddMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AddMedium dialog = new AddMedium();
            if(dialog.ShowDialog()==true)
            {
                dialog.medium.id = media.Count + 1;
                media.Add(dialog.medium);
            }
        }

        private void RemoveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(DataView.SelectedItem != null)
            {
                media.RemoveAt(DataView.SelectedIndex);
            }
        }
    }
}
