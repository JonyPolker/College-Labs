using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work11.Task3
{
    internal class KnightFactory : AbstractFactory
    {
        private int _money = 150;
        private int _iron = 100;

        public KnightFactory(ResourseStorage obj) : base(obj)
        {
            rs = obj;
        }
        public override void Create()
        {
            if (rs.TryGetMoney(_money) == true && rs.TryGetWood(_iron) == true)
            {
                rs.Money -= _money;
                rs.Iron -= _iron;
                Console.WriteLine("Archer create is complite");
            }
        }
    }
}
