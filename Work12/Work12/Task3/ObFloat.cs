using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work12.Task3
{
     internal class ObFloat<T> : Stat<float>
    {
        public ObFloat(float value) : base(Math.Clamp(value, 0f, 100f)) { }
    }
}
