using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;
using System.Reflection.Metadata.Ecma335;

namespace Work6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1.

            string[,] names = new string[2, 2] { { "John", "Fredie" }, { "Michael", "Jason" } };

            // Задание 2.

            Console.WriteLine("Введите число X:");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число Y:");
            int input2 = int.Parse(Console.ReadLine());
            int[,] number = new int[input1, input2];
            for (int no = 0; no < input1; no++)
            {
                for (int nt = 0; nt < input2; nt++)
                {
                    number[no, nt] = no + nt;
                }
            }
            for (int no = 0; no < input1; no++)
            {
                for (int nt = 0; nt < input2; nt++)
                {
                    Console.Write($"{number[no, nt]} ");
                }
                Console.WriteLine();
            }

            // Задание 3.

            int menu3 = 0;
            Console.WriteLine("Введите кол-во сотрудников:");
            int inpute = Int32.Parse(Console.ReadLine());
            string[] number2 = new string[inpute];
            int[,] number3 = new int[inpute, 7];
            int[] number4 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i < inpute; i++)
            {
                number2[i] = "*Имя сотрудника*";
            }
            while (menu3 != 4)
            {
                Console.Clear();
                Console.WriteLine("1.Ввести данные о сотруднике.");
                Console.WriteLine("2.Ввести эффективность сотрудника.");
                Console.WriteLine("3.Отобразить таблицу данных.");
                Console.WriteLine("4.Выход.");
                Console.WriteLine("Для навигации используйте цифры.");
                menu3 = Int32.Parse(Console.ReadLine());
                if (menu3 == 1)
                {
                    Console.Clear();
                    for (int i = 0; i < inpute; i++)
                    {
                        Console.WriteLine($"{i + 1}.{number2[i]}");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Введите порядковый номер сотрудника:");
                    int inputs = Int32.Parse(Console.ReadLine());
                    inputs--;
                    Console.Clear();
                    Console.WriteLine("Введите имя сотрудника:");
                    string namesotr = Console.ReadLine();
                    number2[inputs] = namesotr;
                    Console.WriteLine("Внесение изменений...");
                    Console.WriteLine("Изменения сохранены.");
                    Console.WriteLine("Нажмите на любую клавишу чтобы продолжить.");
                    Console.ReadKey();
                }
                else if (menu3 == 2)
                {
                    Console.Clear();
                    for (int i = 0; i < inpute; i++)
                    {
                        Console.WriteLine($"{i + 1}.{number2[i]}");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Введите порядковый номер сотрудника:");
                    int inputef = Int32.Parse(Console.ReadLine());
                    inputef--;
                    Console.Clear();
                    for (int i = 0; i < 7; i++)
                    {
                        Console.WriteLine($"Введите кол-во клиентов, которых успел обслужить сотрудник за {i + 1} день:");
                        int inputeforone = Int32.Parse(Console.ReadLine());
                        number3[inputef, i] = inputeforone;
                    }
                    Console.WriteLine("Внесение изменений...");
                    Console.WriteLine("Изменения сохранены.");
                    Console.WriteLine("Нажмите на любую клавишу чтобы продолжить.");
                    Console.ReadKey();
                }
                else if (menu3 == 3)
                {
                    Console.Clear();
                    for (int i = 0; i < inpute; i++)
                    {
                        Console.WriteLine($"{i + 1}.{number2[i]}");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Введите порядковый номер сотрудника:");
                    int inputs = Int32.Parse(Console.ReadLine());
                    inputs--;
                    Console.WriteLine();
                    Console.Clear();
                    for (int d = 1; d <= 7; d++)
                    {
                        Console.Write($"{d}. день\t");
                    }
                    Console.Write($"Всего успел обслужить\t");
                    Console.WriteLine();
                    for (int i = 0; i < 7; i++)
                    {
                        int d = 0;
                        Console.Write($"{number3[inputs, i]}\t");
                        d++;
                    }
                    int summ = number3[inputs,0 ] + number3[inputs, 1] + number3[inputs, 2] + number3[inputs, 3] + number3[inputs, 4] + number3[inputs, 5] + number3[inputs, 6];
                    Console.Write(summ);
                    Console.WriteLine();
                    Console.WriteLine("Нажмите любую клавишу чтобы вернуться назад.");
                    Console.ReadKey();
                    Console.Clear();

                }
            }


            // Задание 4.

            const string fiot = "ФИО";
            const string rangt = "Должность";
            const string zpt = "Зарплата";
            int non = 0;
            int ntw = 0;
            string[,] baza = { { "John", "Freddie", "Вакансия", "Вакансия", "Вакансия", "Вакансия", "Вакансия", "Вакансия", "Вакансия", "Вакансия"},
                             { "Директор", "Менеджер", "-", "-", "-", "-", "-", "-", "-", "-"},
                             { "100000", "50000", "-", "-", "-", "-", "-", "-", "-", "-", } };
            int input = 0;
            while (input != 5)
            {
                non = 0;
                ntw = 0;
                Console.WriteLine("1.Добавить сотрудника.");
                Console.WriteLine("2.Удалить сотрудника.");
                Console.WriteLine("3.Отобразить таблицу");
                Console.WriteLine("4.Очисть таблицу.");
                Console.WriteLine("5.Выйти из программы.");
                Console.WriteLine("Для навигации используйте цифры на клавиатуре.");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Введите позицию в списке:");
                    int inputn = Int32.Parse(Console.ReadLine());
                    inputn--;
                    Console.Clear();
                    Console.WriteLine("Введите Ф.И.О. нового сотрудника:");
                    baza[0, inputn] = Console.ReadLine();
                    Console.WriteLine("Введите должность нового сотрудника:");
                    baza[1, inputn] = Console.ReadLine();
                    Console.WriteLine("Введите оклад нового сотрудника:");
                    baza[2, inputn] = Console.ReadLine();
                    Console.WriteLine("Нажмите любую клавишу чтобы вернуться назад.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Введите порядковый номер сотрудника, которого хотите удалить и базы данных:");
                    int inputd = Int32.Parse(Console.ReadLine());
                    inputd--;
                    for (non = 0; non < 3; non++)
                    {
                        if (non == 0)
                        {
                            baza[non, inputd] = "Вакантно";
                        }
                        else if (non != 0)
                        {
                            baza[non, inputd] = "-";
                        }
                    }
                    Console.WriteLine("Нажмите любую клавишу чтобы вернуться назад.");
                    Console.ReadKey();
                    Console.Clear();

                }
                else if (input == 3)
                {
                    Console.Clear();
                    non = 0;
                    ntw = 0;
                    Console.WriteLine($"{fiot}\t\t{rangt}\t\t{zpt}");
                    Console.WriteLine();
                    for (ntw = 0; ntw < 10; ntw++)
                    {
                        for (non = 0; non < 3; non++)
                        {
                            Console.Write($"{baza[non, ntw]}\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Нажмите любую клавишу чтобы вернуться назад.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == 4)
                {
                    Console.Clear();
                    for (non = 0; non < 3; non++)
                    {
                        for (ntw = 0; ntw < 10; ntw++)
                        {
                            if (non == 0)
                            {
                                baza[non, ntw] = "Вакансия";
                            }
                            else if (non != 0)
                            {
                                baza[non, ntw] = "-";
                            }
                        }
                    }
                    Console.WriteLine("Очистка...");
                    Console.WriteLine("Очистка прошла успешна.");
                    Console.WriteLine("Нажмите любую клавишу чтобы вернуться назад.");
                    Console.ReadKey();
                    Console.Clear();
                }

            }






        }
    }
}
