using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work12.Task2
{
    internal class Person
    {
        private string name;
        private int age;

        public Person(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
        public override string ToString()
        {
            return $"Name is {name}, age is {age} years.";
        }
    }
}
