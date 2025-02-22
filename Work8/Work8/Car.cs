using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work8
{
    internal class Car
    {
        public int speed;
        public int acceleration;
        public int stop;
        public Car(int NewSpeed, int NewAcceleration)
        {
            speed = NewSpeed;
            acceleration = NewAcceleration;
            stop = NewAcceleration * 2;
        }
        public void Accelerate()
        {
            speed += acceleration;
        }
        public void Break()
        {
            speed -= stop;
        }
    }
}
