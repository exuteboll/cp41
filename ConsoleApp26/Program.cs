using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>
            {
                new Book("абалблаблаб", "блэблэблэ", "блублублу"),
                new Book("бхапблублу", "атата","пимпим"),
                new Book("вбрбрбр", "патапим", "сагур"),
            };
            var sortBook = from p in books
                                orderby p.Title
                                select p;
            foreach (var p in sortBook)
                Console.WriteLine($"{p.Title} - {p.Author} - {p.Publishing}");
            
            Console.ReadKey();
        }
    }
}
