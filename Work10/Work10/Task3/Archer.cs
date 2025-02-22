using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work10.Task3
{
    internal class Archer : Unit
    {
        private int _accuracy;

        public Archer() : base()
        {
            Random rnd = new Random();
            _accuracy = rnd.Next(1, 4);
        }

        public int Accuracy => _accuracy;
    }
}
