using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work13.Task3
{
    internal class Plane : IFlyable, IDrivable
    {
        public string Name { get; }
        public Plane(string name)
        {
            Name = name;
        }
    }
}
