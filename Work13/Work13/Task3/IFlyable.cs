using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work13.Task3
{
    internal interface IFlyable
    {
        void Move()
        {
            Console.WriteLine("Vehicle is fly.");
        }
    }
}
