using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work11.Task3
{
    abstract internal class AbstractFactory
    {
        private protected ResourseStorage rs;
        public AbstractFactory(ResourseStorage obj)
        {
            rs = obj;
        }

        public abstract void Create();
    }
}
