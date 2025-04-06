using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work13.Task3
{
    internal class Boat : ISwimmable
    {
        public string Name { get; }
        public Boat(string name)
        {
            Name = name;
        }
    }
}
