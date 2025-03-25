using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work12.Task3
{
    internal class ObInt<T> : Stat<int>
    {
        private int maxValue;
        public ObInt(int value, int maxValue) : base(Math.Clamp(value, 0, maxValue))
        {
            this.maxValue = maxValue;
        }
    }
}
