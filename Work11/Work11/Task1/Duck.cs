using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work11.Task1
{
    internal class Duck : Animal
    {
        public Duck(string name) : base(name)
        {
            _name = name;
        }
        public override void Sound()
        {
            Console.WriteLine($"{_name} крякнул!");
        }
    }
}
