using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Book
    {
        public string author;
        public int pages;
        public string isbn;
        public string title;
        public int currentPage;

        public Book()
        {
            currentPage = 1;
        }

        public Book(string author, int pages, string isbn, string title, int currentPage)
        {
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.title = title;
            this.currentPage = currentPage;
        }
        public void FlipPageBackWord()
        {
            currentPage--;
            Console.WriteLine("Recent Page: " + currentPage);
        }

        public void FlipPageForward()
        {
            currentPage++;
            Console.WriteLine("Recent Page: " + currentPage);
        }
    }
}
