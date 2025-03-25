using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work12.Task3
{
    internal class ItemStat<T> : Stat<T> where T : Item
    {
        public ItemStat(T variab) : base(variab)
        {

        }
    }
}
