using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work10.Task3
{
    internal class Cavalry : Unit
    {
        private int _speed;

        public Cavalry() : base()
        {
            Random rnd = new Random();
            _speed = rnd.Next(1, 4);
        }

        public int Speed => _speed;
    }
}
