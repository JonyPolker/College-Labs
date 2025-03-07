using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work11.Task1
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
            _name = name;
        }
        public override void Sound()
        {
            Console.WriteLine($"{_name} мяукнул!");
        }
    }
}
