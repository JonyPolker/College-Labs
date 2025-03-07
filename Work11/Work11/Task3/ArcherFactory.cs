using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work11.Task3
{
    internal class ArcherFactory : AbstractFactory
    {
        private int _money = 50;
        private int _wood = 50;

        public ArcherFactory(ResourseStorage obj) : base(obj)
        {
            rs = obj;
        }
        public override void Create()
        {
            if(rs.TryGetMoney(_money) == true && rs.TryGetWood(_wood) == true)
            {
                rs.Money -= _money;
                rs.Wood -= _wood;
                Console.WriteLine("Archer create is complite");
            }
        }
    }
}
