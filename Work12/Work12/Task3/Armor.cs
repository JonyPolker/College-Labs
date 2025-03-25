using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work12.Task3
{
    internal class Armor : Item
    {
        private ObInt<int> defense;

        public ObInt<int> Defense => defense;
        public Armor(string Name, int Defense) : base(Name)
        {
            defense = new ObInt<int>(Defense, 100);
        }
    }
}
