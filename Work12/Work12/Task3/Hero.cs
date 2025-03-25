using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Work12.Task3
{
    internal class Hero
    {
        private ObInt<int> heath;
        private ObFloat<float> dodgeChance;
        private ItemStat<Weapon> weapon;
        private ItemStat<Armor> armor;

        public ObInt<int> Heath => heath;
        public ObFloat<float> DC => dodgeChance;
        public ItemStat<Weapon> Damage => weapon;
        public ItemStat<Armor> Defense => armor;

        public Hero(int Heath, float DC, Weapon Weapon, Armor Armor)
        {
            heath = new ObInt<int>(Heath, 200);
            dodgeChance = new ObFloat<float>(DC);
            weapon = new ItemStat<Weapon>(Weapon);
            armor = new ItemStat<Armor>(Armor);
        }
    }
}
