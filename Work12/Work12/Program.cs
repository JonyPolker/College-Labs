using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using Work12.Task1;
using Work12.Task2;
using Work12.Task3;

namespace Work12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            var ms = new MyStack<int>();
            bool isEmp1 = ms.isEmpty();
            if (isEmp1 == true) Console.WriteLine("В массиве есть элементы.");
            else Console.WriteLine("В массиве нету элементов.");
            ms.Push(1);
            bool isEmp2 = ms.isEmpty();
            if (isEmp2 == true) Console.WriteLine("В массиве есть элементы.");
            else Console.WriteLine("В массиве нету элементов.");
            ms.Pop();
            bool isEmp3 = ms.isEmpty();
            if (isEmp3 == true) Console.WriteLine("В массиве есть элементы.");
            else Console.WriteLine("В массиве нету элементов.");
            ms.Push(2);
            ms.Push(3);
            int oi = ms.Pop();
            ms.Push(4);
            ms.Push(5);
            foreach (int i in ms.Items)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"number {oi} is output");

            // Task 2

            string[] str = {"Metro", "Bus", "Skate", "Bike"};
            int[] num = { 14, 25, 30, 26 };
            Transport[] ts = {new Transport("Logan",84), new Transport("Challenger", 1025), new Transport("Matiz", 51), new Transport("Жигули", 74)};
            Person[] pn = {new Person("Dave", 24), new Person("John", 20), new Person("Vasya", 19), new Person("Genrich", 43)};
            Food[] food = {new Food("Pizza", 3), new Food("Шаурма", 2), new Food("Burger", 3), new Food("Чебурек", 2) };
            Console.WriteLine("\nString:");
            GenerateReport(str);
            Console.WriteLine("\nInt:");
            GenerateReport(num);
            Console.WriteLine("\nTransport:");
            GenerateReport(ts);
            Console.WriteLine("\nPerson:");
            GenerateReport(pn);
            Console.WriteLine("\nFood:");
            GenerateReport(food);

            // Task 3

            Weapon sword = new Weapon("Sword", 50);
            Armor shield = new Armor("Shield", 40);

            Hero hero = new Hero(200, 15f, sword, shield);

            Console.WriteLine($"Heath is {hero.Heath.Value}");
            Console.WriteLine($"DodgeChance is {hero.DC.Value}%");
            Console.WriteLine($"Weapon is {hero.Damage.Value.Name}, damage is {hero.Damage.Value.Damage.Value}");
            Console.WriteLine($"Eqip Defense is {hero.Defense.Value.Name}, Defense is {hero.Defense.Value.Defense.Value}");
        }

        static public void GenerateReport<T>(T[] array)
        {
            foreach(T e in array)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
;}
