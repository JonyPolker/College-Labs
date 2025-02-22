using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1.

            Console.WriteLine("Введите имя:");
            string inputname = Console.ReadLine();
            Console.Clear();
            Hello(inputname);
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить.");
            Console.ReadKey();

            // Задание 2.

            Console.Clear();
            Console.WriteLine("Введите длину:");
            int dl = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите ширину:");
            int shr = Int32.Parse(Console.ReadLine());
            int c = Circulation(dl, shr);
            Console.Clear();
            Console.WriteLine($"Площадь - {c}");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить.");
            Console.ReadKey();

            // Задание 3.
            Console.Clear();
            Console.WriteLine("Введите длинну массива:");
            int dm = Int32.Parse(Console.ReadLine());
            int[] massiv1 = new int[dm];
            dm--;
            for (int i = 0; i <= dm; i++)
            {
                massiv1[i] = i + 1;
            }
            int summa = Summary(massiv1, 0);
            Console.WriteLine($"Сумма - {summa}");


            Console.WriteLine("Нажмите любую клавишу чтобы продолжить.");
            Console.ReadKey();

            // Задание 4.

            int menu = 0;
            while (menu != 5)
            {
                Console.Clear();
                Console.WriteLine("1. Удвоение всех чисел с выводом");
                Console.WriteLine("2. Удвоение целочисленного числа");
                Console.WriteLine("3. Удвоение значений в массиве");
                Console.WriteLine("4. Перебор и вывод чисел в консоль");
                Console.WriteLine("5. Выход");
                Console.WriteLine("Для выбора используйте цифры на клавиатуре.");
                menu = Int32.Parse(Console.ReadLine());
                Console.Clear();
                if (menu == 1)
                {
                    Console.WriteLine("Введите длинну массива:");
                    int dm2 = Int32.Parse(Console.ReadLine());
                    int[] progmassiv = new int[dm2];
                    int dlina = progmassiv.Length;
                    for (int i = 0; i < dm2; i++)
                    {
                        progmassiv[i] = i + 1;
                    }
                    Console.Clear();
                    for (int i = 0; i < dlina; i++)
                    {
                        int udv = Udvoenie(progmassiv[i]);
                        Console.WriteLine(udv);
                    }
                    Console.WriteLine("Нажмите любую клавишу чтобы продолжить.");
                    Console.ReadKey();
                }
                else if (menu == 2)
                {
                    Console.WriteLine("Введите число:");
                    int input2 = Int32.Parse(Console.ReadLine());
                    int output = udvnumb(input2);
                    Console.Clear();
                    Console.WriteLine(output);
                    Console.WriteLine("Нажмите любую клавишу чтобы продолжить.");
                    Console.ReadKey();
                }
                else if (menu == 3)
                {
                    Console.WriteLine("Введите длинну массива:");
                    int dm4 = Int32.Parse(Console.ReadLine());
                    int[] progmassiv4 = new int[dm4];
                    int dlina4 = progmassiv4.Length;
                    for (int i = 0; i < dm4; i++)
                    {
                        progmassiv4[i] = i + 1;
                    }
                    Console.Clear();
                    udvmassiva(progmassiv4);
                    Console.WriteLine($"Введите номер числа, у которого хотите проверить значение:");
                    int ind = Int32.Parse(Console.ReadLine());
                    ind--;
                    Console.Clear();
                    Console.WriteLine(progmassiv4[ind]);
                    Console.WriteLine("Нажмите любую клавишу чтобы продолжить.");
                    Console.ReadKey();
                }
                else if (menu == 4)
                {
                    Console.WriteLine("Введите длинну массива:");
                    int dm5 = Int32.Parse(Console.ReadLine());
                    int[] progmassiv5 = new int[dm5];
                    int dlina5 = progmassiv5.Length;
                    for (int i = 0; i < dm5; i++)
                    {
                        progmassiv5[i] = i + 1;
                    }
                    Console.Clear();
                    perebor(progmassiv5);
                    Console.WriteLine("Нажмите любую клавишу чтобы продолжить.");
                    Console.ReadKey();
                }

                // Задание 5.

                Console.Clear();
                Console.WriteLine("Введите число:");
                int number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите степень в которую необходимо возвести число:");
                int power = Int32.Parse(Console.ReadLine());
                int[] powerm = new int[power];
                for (int i = 0; i < power; i++)
                {
                    powerm[i] = number;
                }
                int otvpower = powernumber(powerm);
                Console.WriteLine(otvpower);
                Console.WriteLine("Нажмите любую клавишу чтобы продолжить.");
                Console.ReadKey();
            }


        }

        static void Hello(string inputname)
        {
            Console.WriteLine($"Hello, {inputname}");
        }


        static int Circulation(int a, int b)
        {
            int c = a * b;
            return c;
        }

        static int Summary(int[] massiv1, int b)
        {
            Console.Clear();
            int mlth = massiv1.Length;
            for (int i = 0; i < mlth; i++)
            {
                b += massiv1[i];
            }
            return b;
        }

        static int Udvoenie(int elmmasiva)
        {


            int udv = elmmasiva * 2;
            Console.WriteLine($"{elmmasiva} * 2 = {elmmasiva * 2}");
            return udv;

        }
        static int udvnumb(int number)
        {
            int proizv = number * 2;
            return proizv;
        }
        static int[] udvmassiva(int[] massiv)
        {
            int dm3 = massiv.Length;
            for (int i = 0; i < dm3; i++)
            {
                massiv[i] = i * 2;
            }
            return massiv;
        }
        static int[] perebor(int[] massiv)
        {
            int dlina5 = massiv.Length;
            for (int i = 0; i < dlina5; i++)
            {
                Console.WriteLine(massiv[i]);
            }
            return massiv;
        }
        static int powernumber(int[] massiv)
        {
            int dlina6 = massiv.Length;
            int powers = 1;
            for (int i = 0; i < dlina6; i++)
            {
                powers *= massiv[i];
            }
            return powers;
        }
    }

}