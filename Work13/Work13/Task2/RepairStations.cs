using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work13.Task2
{
    internal class RepairStations
    {
        public void Repair(IRepairable obj)
        {
            obj.Repair();
        }
    }
}
