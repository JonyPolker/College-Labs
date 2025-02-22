using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work10.Task3
{
    internal class Infintary : Unit
    {
        private int _heath;

        public Infintary() : base()
        {
            Random rnd = new Random();
            _heath = rnd.Next(1, 4);
        }

        public int Health => _heath;
    }
}
