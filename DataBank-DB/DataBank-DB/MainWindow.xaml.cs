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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataBank_DB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string ConString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\work\pb069\PB069\DataBank-DB\DataBank-DB\databank.mdf;Integrated Security=True;Connect Timeout=30";

        
        public MainWindow()
        {
            InitializeComponent();
            FillData();
        }

        private void FillData()
        {
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                string cmdString = "select * from dbo.DVDs";
                SqlCommand cmd = new SqlCommand(cmdString, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable table = new DataTable("dataDataSet");
                sda.Fill(table);
                DVDGrid.ItemsSource = table.DefaultView;
            }
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AddMedium dialog = new AddMedium();
            if (dialog.ShowDialog() == true)
            {
                Medium medium = dialog.medium;
                AddMedium(medium);
                FillData();
            }
        }

        private void AddMedium(Medium medium)
        {
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                string cmdString = "insert into dbo.DVDS(title,year,director) values (@title,@year,@director)";
                SqlParameter titleParam = new SqlParameter("@title", medium.title),
                             yearParam = new SqlParameter("@year", medium.year),
                             directorParam = new SqlParameter("@director", medium.director);
                SqlCommand cmd = new SqlCommand(cmdString, con);
                cmd.Parameters.Add(titleParam);
                cmd.Parameters.Add(yearParam);
                cmd.Parameters.Add(directorParam);
                int id =(int) cmd.ExecuteNonQuery();
                //medium.id = id;

            }
        }

        private void RemoveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (DVDGrid.SelectedItem == null)
            {
                return;
            }
            DataRow row = (DVDGrid.SelectedItems[0] as DataRowView).Row;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                int id = (int)row["id"];
                SqlCommand cmd = new SqlCommand("delete from dbo.DVDS where id=@id",con);
                SqlParameter idParam = new SqlParameter("@id", row["id"]);
                cmd.Parameters.Add(idParam);
                cmd.ExecuteNonQuery();
            }
            FillData();
        }

        
    }
}
