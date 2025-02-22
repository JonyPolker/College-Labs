using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Задание 1.

            Person hum1 = new Person("Сергей", 16, "Гос. Дума");
            Person hum2 = new Person("Вася", 52, "Высокооплачиваемая");

            Program Pr = new Program();
            int menu1 = 0;
            while (menu1 != 3)
            {
                Console.Clear();
                Console.WriteLine("1. Meet");
                Console.WriteLine("2. GoToJob");
                Console.WriteLine("3. Выход");
                Console.WriteLine("Используйте цифры для навигации.");
                menu1 = Int32.Parse(Console.ReadLine());
                if (menu1 == 1)
                {
                    Pr.Meet(hum1.name, hum1.age);
                }
                else if (menu1 == 2)
                {
                    Pr.GoToJob(hum1.name, hum1.job);
                }
            }


            // Задание 2

            Console.Clear();

            Bank user = new Bank(0, hum1.name);
            Bank user1= new Bank(0, hum2.name);

            user.AddMoney(10000);

            Console.WriteLine("Нажмите любую клавишу для продолжения.");
            Console.ReadKey();

            user1.Remove(15000);

            Console.WriteLine("Нажмите любую клавишу для продолжения.");
            Console.ReadKey();

            user.SendMoney(18000, user1);

            Console.WriteLine("Нажмите любую клавишу для продолжения.");
            Console.ReadKey();

            // Задание 3.

            Console.Clear();
            Console.WriteLine("Введите скорость автомобиля:");
            int NewSpeed = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите ускорение автомобиля:");
            int NewAcceleration = Int32.Parse(Console.ReadLine());
            Car car = new Car(NewSpeed, NewAcceleration);
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Итерация - {i + 1}.");
                Random rnd = new Random();
                int randomchik = rnd.Next(1, 3);
                if (randomchik == 1)
                {
                    car.Accelerate();
                }
                else if (randomchik == 2)
                {
                    car.Break();
                }
                Radar limits1 = new Radar(0, 200);
                limits1.Check(car.speed);
                Console.WriteLine($"Скорость - {car.speed} км/ч");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        void Meet(string name, int age)
        {
            Console.Clear();
            Console.WriteLine($"Привет! Меня зовут {name}! Мой возраст - {age} лет.");
            Console.WriteLine("Нажмите любую клавишу для продолжения.");
            Console.ReadKey();
        }
        void GoToJob(string name, string job)
        {
            Console.Clear();
            Console.WriteLine($"{name} пошел на работу. Его работа - {job}.");
            Console.WriteLine("Нажмите любую клавишу для продолжения.");
            Console.ReadKey();
        }
    }
}
