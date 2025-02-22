using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work10.Task2
{
    internal class Ant
    {
        private int _strength;
        public Ant(int strenght)
        {
            _strength = strenght;
        }

        public int Strenght => _strength;

        public bool TryPick(Fruit fruit)
        {
            if (fruit is Apple)
            {
                if (_strength >= 10)
                {
                    return true;
                }
            }
            else if (fruit is Kiwi)
            {
                if (_strength >= 5)
                {
                    return true;
                }
            }
            else if (fruit is Banana)
            {
                if (_strength >= 15)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
