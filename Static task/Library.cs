using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_task
{
    public class Library
    {

        private readonly int bookLimit;

        private readonly List<Book> books = new List<Book>();

        public Library(int bookLimit) { this.bookLimit = bookLimit; }

        public void AddBook(Book book)
        {
            if (books.Count <= bookLimit) { books.Add(book); }
            else { throw new Exception("Kitab limiti keçildi."); }
        }

    }
}
