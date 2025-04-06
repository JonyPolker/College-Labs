using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work13.Task3
{
    internal class Car : IDrivable
    {
        public string Name { get;}
        public Car(string name)
        {
            Name = name;
        }
    }
}
