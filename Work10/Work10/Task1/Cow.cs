using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Work10.Task1
{
    internal class Cow : Animal
    {
        public Cow(string name) : base(name)
        {

        }

        public void Moo()
        {
            Console.WriteLine($"{Name} говорит: Муу!");
        }
    }
}
