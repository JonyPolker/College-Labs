using Work10.Task1;
using Work10.Task2;
using Work10.Task3;

namespace Work10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            Cat cat = new Cat("Барсик");
            Dog dog = new Dog("Тузик");
            Cow cow = new Cow("Корова");

            cat.Meow();
            dog.Bark();
            cow.Moo();

            Console.WriteLine("Для продолжения нажмите любую клавишу:");
            Console.ReadKey();

            // Task 2

            Console.Clear();
            Random rnd = new Random();
            Ant ant = new Ant(rnd.Next(1, 21));
            Fruit[] fruit = new Fruit[10];
            for (int i = 0; i < 10; i++)
            {
                Random rndm = new Random();

                int fm = rndm.Next(1, 4);
                if (fm == 1)
                {
                    fruit[i] = new Apple("Яблоко");
                }
                else if (fm == 2)
                {
                    fruit[i] = new Banana("Банан");
                }
                else if (fm == 3)
                {
                    fruit[i] = new Kiwi("Киви");
                }
                Console.WriteLine($"{i + 1}. {fruit[i].Name}");

            }

            Console.WriteLine($"Сила муравья - {ant.Strenght}");

            int kolvo = 0;

            for (int i = 0; i < 10; i++)
            {
                if (true == ant.TryPick(fruit[i]))
                {
                    kolvo++;
                }
            }

            Console.WriteLine($"Муравей смог поднять {kolvo} фруктов.");

            Console.WriteLine("Для продолжения нажмите любую клавишу:");
            Console.ReadKey();

            // Task 3

            Console.Clear();

            Unit[,] unit = new Unit[2, 5];

            for (int na = 0; na < 2; na++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Random rnda = new Random();
                    int nar = rnda.Next(1, 4);
                    if (nar == 1)
                    {
                        unit[na, i] = new Infintary();
                    }
                    else if (nar == 2)
                    {
                        unit[na, i] = new Archer();
                    }
                    else if (nar == 3)
                    {
                        unit[na, i] = new Cavalry();
                    }
                }
            }

            int[,] voyskotemnoe = new int[2, 3];

            for (int m = 0; m < 2; m++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (unit[m, i] is Infintary)
                    {
                        voyskotemnoe[m, 0] += 1;
                    }
                    else if (unit[m, i] is Archer)
                    {
                        voyskotemnoe[m, 1] += 1;
                    }
                    else if (unit[m, i] is Cavalry)
                    {
                        voyskotemnoe[m, 2] += 1;
                    }
                }
            }

            int dm = 1;
            decimal[] pm = new decimal[2];
            for (int a = 0; a < 2; a++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (unit[a, i] is Infintary infintary)
                    {
                        pm[a] += (unit[a, i].War_spirit + infintary.Health) * voyskotemnoe[dm, 0];
                    }
                    else if (unit[a, i] is Archer archer)
                    {
                        pm[a] += (unit[a, i].War_spirit + archer.Accuracy) * voyskotemnoe[dm, 1];
                    }
                    else if (unit[a, i] is Cavalry cavalry)
                    {
                        pm[a] += (unit[a, i].War_spirit + cavalry.Speed) * voyskotemnoe[dm, 2];
                    }
                }
                dm--;
            }

            decimal ap = pm[0] + pm[1];
            decimal[] chance = { pm[0] / ap * 100, pm[1] / ap * 100 };
            Console.WriteLine($"Шанс на победу 1-ой армии - {chance[0]}%");
            Console.WriteLine($"Шанс на победу 2-ой армии - {chance[1]}%");
        }
    }
}
