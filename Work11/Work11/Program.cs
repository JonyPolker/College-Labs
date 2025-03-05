using Work11.Task1;
using Work11.Task2;
using Work11.Task3;

namespace Work11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            Cat cat = new Cat("Мурзик");
            Dog dog = new Dog("Тузик");
            Duck duck = new Duck("Леня");

            cat.Sound();
            dog.Sound();
            duck.Sound();

            // Task 2

            Random rnd = new Random();
            Bank[] bank = new Bank[10];
            for (int i = 0; i < bank.Length; i++)
            {
                int number = rnd.Next(1, 4);
                if (number == 1)
                {
                    bank[i] = new SberBank("СберБанк");
                }
                else if (number == 2)
                {
                    bank[i] = new AlphaBank("АльфаБанк");
                }
                else if (number == 3)
                {
                    bank[i] = new VtbBank("ВТБ");
                }
            }

            for (int i = 0; i < bank.Length; i++)
            {
                bank[i].Use();
            }

            // Task 3

        }
    }
}
