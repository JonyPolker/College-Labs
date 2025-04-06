using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work13.Task2
{
    internal class Robot : IRepairable
    {
        public void Repair()
        {
            Console.WriteLine("Ремонтная станция обслуживает робота.");
        }
    }
}
