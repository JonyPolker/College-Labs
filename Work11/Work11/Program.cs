using System.ComponentModel.Design;
using System.Diagnostics;
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

            Stop();

            // Task 2

            Console.Clear();

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

            Stop();

            // Task 3

            Console.Clear();

            var rs = new ResourseStorage();
            AbstractFactory[] arr =
            {
                new ArcherFactory(rs),
                new InfinitaryFactory(rs),
                new KnightFactory(rs)
            };
            int key;
            int key1;
            int key2;
            int menu = 0;
            while (menu != 4)
            {
                Console.Clear();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Просмотр ресурсов.");
                Console.WriteLine("2. Изменение ресурсов.");
                Console.WriteLine("3. Использование фабрики.");
                Console.WriteLine("4. Выход.");
                key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"Денег в хранилище - {rs.Money}");
                        Console.WriteLine($"Дерева в хранилище - {rs.Wood}");
                        Console.WriteLine($"Железа в хранилище - {rs.Iron}");
                        Stop();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("1. Деньги.");
                        Console.WriteLine("2. Дерево.");
                        Console.WriteLine("3. Железо.");
                        Console.WriteLine("Выберите ресурс количество которого хотите изменить:");
                        key1 = int.Parse(Console.ReadLine());
                        switch(key1)
                        {
                            case 1:
                                while(true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Введите новое количество, не менее 0 ед., но не более 500 ед.:");
                                    int input = int.Parse(Console.ReadLine());
                                    if (input >= 0 && input <= 500)
                                    {
                                        rs.Money = input;
                                        Console.WriteLine($"Количество успешно изменено на {rs.Money}.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ошибка ввода.");
                                        Stop();
                                    }
                                }
                                Stop();
                                break;
                            case 2:
                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Введите новое количество, не менее 0 ед., но не более 500 ед.:");
                                    int input = int.Parse(Console.ReadLine());
                                    if (input >= 0 && input <= 500)
                                    {
                                        rs.Wood = input;
                                        Console.WriteLine($"Количество успешно изменено на {rs.Wood}.");
                                        break;
                                    }
                                }
                                Stop();
                                break;
                            case 3:
                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Введите новое количество, не менее 0 ед., но не более 500 ед.:");
                                    int input = int.Parse(Console.ReadLine());
                                    if (input >= 0 && input <= 500)
                                    {
                                        rs.Iron = input;
                                        Console.WriteLine($"Количество успешно изменено на {rs.Iron}.");
                                        break;
                                    }
                                }
                                Stop();
                                break;
                        }
                        break;
                    case 3:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("1. Archer Factory.");
                            Console.WriteLine("2. Infinitary Factory.");
                            Console.WriteLine("3. Knight Factory.");
                            Console.WriteLine("Выберите фабрику, которую хотите использовать:");
                            key2 = int.Parse(Console.ReadLine());
                            if (key2 == 1)
                            {
                                Console.Clear();
                                arr[0].Create();
                                Stop();
                                break;
                            }
                            else if (key2 == 2)
                            {
                                Console.Clear();
                                arr[1].Create();
                                Stop();
                                break;
                            }
                            else if (key2 == 3)
                            {
                                Console.Clear();
                                arr[2].Create();
                                Stop();
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Ошибка ввода.");
                                Stop();
                            }
                            break;
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Выход из программы...");
                        menu = key;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ошибка ввода...");
                        Stop();
                        break;
                }
            }
        }


        public static void Stop()
        {
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить: ");
            Console.ReadKey();
        }
    }
}
