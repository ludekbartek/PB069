using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksFile
{
    internal class Book
    {
        public String? title { get; set; }
        public string? author { get; set; }
        public uint? published { get; set; }
        public override string ToString()
        {
            return string.Format("{0};{1};{2}",title,author,published);
        }

        public Book parse(string line)
        {
            string[] part = line.Split(";", 3);
            Book book = new Book();
            book.title = part[0];
            book.author = part[1];
            book.published = UInt16.Parse(part[2]);
            return book;
        }
    }
}
