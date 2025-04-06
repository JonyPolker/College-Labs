using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work13.Task1
{
    internal class Book : IPrintable, IReadable
    {
        private string title;
        public Book(string Title)
        {
            title = Title;
        }

        public string Title => title;

        public void Print()
        {
            Console.WriteLine(title);
        }

        public void Read()
        {
            Console.WriteLine($"Читаю книгу - {title}");
        }
    }
}
