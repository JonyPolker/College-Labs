using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work13.Task1
{
    internal class Magazine : IPrintable
    {
        private string title;
        public Magazine(string Title)
        {
            title = Title;
        }
        public string Title => title;

        public void Print()
        {
            Console.WriteLine(title);
        }
    }
}
