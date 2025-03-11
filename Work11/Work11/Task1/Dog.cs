using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Work11.Task1
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            _name = name;
        }
        public override void Sound()
        {
            Console.WriteLine($"{_name} гавкнул!");
        }
    }
}
