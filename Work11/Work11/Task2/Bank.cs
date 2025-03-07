using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work11.Task2
{
    internal class Bank
    {
        protected string _name;
        public Bank(string name)
        {
            _name = name;
        }

        public virtual void Use()
        {
            Console.WriteLine("Спасибо что пользуетесь нашими банком!");
        }
    }
}
