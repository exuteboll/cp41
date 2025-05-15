using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publishing { get; set; }

        public Book(string title, string author, string publisher)
        {
            Title = title;
            Author = author;
            Publishing = publisher;
        }
        public override string ToString()
        {
            return $"Название: {Title}\t Автор: {Author}\t Издательство{Publishing}";
        }
    }
}
