using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work12.Task2
{
    internal class Food
    {
        private string dish;
        private int cost;

        public Food(string Dish, int Cost)
        {
            dish = Dish;
            cost = Cost;
        }
        public override string ToString()
        {
            return $"Name of the dish {dish}, cost is {cost}$.";
        }
    }
}
