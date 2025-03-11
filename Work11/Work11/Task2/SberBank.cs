using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Work11.Task2
{
    internal class SberBank : Bank
    {
        public SberBank(string name) : base(name)
        {
            _name = name;
        }
        public override void Use()
        {
            Console.WriteLine($"Спасибо что пользуетесь услугами банка - {_name}!");
        }
    }
}
