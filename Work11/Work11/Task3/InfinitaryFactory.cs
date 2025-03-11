using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work11.Task3
{
    internal class InfinitaryFactory : AbstractFactory
    {
        private int _money = 50;
        private int _wood = 10;
        private int _iron = 25;

        public InfinitaryFactory(ResourseStorage obj) : base(obj)
        {
            rs = obj;
        }
        public override void Create()
        {
            if (rs.TryGetMoney(_money) == true && rs.TryGetWood(_wood) == true && rs.TryGetIron(_iron) == true)
            {
                rs.Money -= _money;
                rs.Wood -= _wood;
                rs.Iron -= _iron;
                Console.WriteLine("Infinitary create is complite");
            }
        }
    }
}
