namespace BooksFile
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.title = titleBox.Text;
            book.author = authorBox.Text;
            book.published = (uint)publishedUpDown.Value;
            textBox3.Text += book.ToString() + '\n';


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}