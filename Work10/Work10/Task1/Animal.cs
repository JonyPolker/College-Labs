using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work10.Task1
{
    internal class Animal
    {
        private string _name;

        public Animal(string name)
        {
            _name = name;
        }

        public string Name => _name;
    }
}
