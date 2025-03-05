using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work11.Task1
{
    abstract internal class Animal
    {
        public string _name;
        
        public Animal(string name)
        {
            _name = name;
        }
        abstract public void Sound();
    }
}
