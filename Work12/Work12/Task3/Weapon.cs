using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work12.Task3
{
    internal class Weapon : Item
    {
        private ObInt<int> damage;

        public ObInt<int> Damage => damage;
        public Weapon(string Name, int Damage) : base(Name)
        {
            damage = new ObInt<int>(Damage, 100);
        }
    }
}
