using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work10.Task2
{
    internal class Fruit
    {
        protected private string _name;

        public Fruit()
        {
            _name = "Fruit";
        }
        public string Name => _name;
    }
}
