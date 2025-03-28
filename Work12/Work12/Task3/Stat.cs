using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work12.Task3
{
    internal class Stat<T>
    {
        private virtual protected T value;

        public T Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }
        public Stat(T variab)
        {
            value = variab;
        }
    }
}
