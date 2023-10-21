using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Bai3_5
    {
        public void Book()
        {
            Book book1 = new Book();
            Book book2 = new Book("Viet Ha", 100, "AB123", "CSharp", 10);

            book1.author = "viet ha";
            book1.pages = 50;
            book1.isbn = "ab123";
            book1.title = "Title";

            Console.WriteLine("Book 1: ");
            Console.WriteLine("Author: " + book1.author);
            Console.WriteLine("Pages: " + book1.pages);
            Console.WriteLine("Book Number: " + book1.isbn);
            Console.WriteLine("Title: " + book1.title);
            Console.WriteLine("Current Page: " + book1.currentPage);
            book1.FlipPageForward();
            book1.FlipPageBackWord();
            Console.WriteLine();

            Console.WriteLine("Book 2: ");
            Console.WriteLine("Author: " + book2.author);
            Console.WriteLine("Pages: " + book2.pages);
            Console.WriteLine("Book Number: " + book2.isbn);
            Console.WriteLine("Title: " + book2.title);
            Console.WriteLine("Current Page: " + book2.currentPage);

            book2.FlipPageBackWord();
            book2.FlipPageForward();

        }
    }
}
