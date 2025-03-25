using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work12.Task2
{
    internal class Transport
    {
        private string model;
        private int hp; // Horse Power

        public Transport(string Model, int HP)
        {
            model = Model;
            hp = HP;
        }
        public override string ToString()
        {
            return $"Model is {model}, power is {hp} horsepower.";
        }
    }
}
