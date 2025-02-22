using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work8
{
    internal class Radar
    {
        public int spidmin;
        public int spidmax;

        public Radar(int min, int max)
        {
            spidmin = min;
            spidmax = max;
        }

        internal void Check(int speed)
        {
            if (speed < spidmin || speed > spidmax)
            {
                Console.WriteLine("Вы нарушаеье скоростноой режим!");
            }
        }
    }
}