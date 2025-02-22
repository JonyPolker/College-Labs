using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Work10.Task1
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        {

        }

        public void Bark()
        {
            Console.WriteLine($"{Name} говорит: Гав!");
        }
    }
}
