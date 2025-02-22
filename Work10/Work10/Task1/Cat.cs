using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Work10.Task1
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {

        }

        public void Meow()
        {
            Console.WriteLine($"{Name} говорит: Мяу!");
        }
    }
}
