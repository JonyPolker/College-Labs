using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work10.Task3
{
    internal class Unit
    {
        private int _war_spirit;

        public Unit()
        {
            Random rnd = new Random();
            _war_spirit = rnd.Next(1, 4);
        }

        public int War_spirit => _war_spirit;
    }
}
