using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Work4
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // Практическая работа 4.
             // Задание 1.

             Console.WriteLine("Введите текст:");
             string txt = Console.ReadLine();
             Console.WriteLine("Введите то, сколько раз должен повториться текст:");
             int N = Int32.Parse(Console.ReadLine());
             int NW = 0;
             while (NW < N)
             {
                 ++NW;
                 Console.WriteLine($"{NW}. {txt}");

             }

             Console.WriteLine("Нажмите Enter чтобы продолжить:");
             Console.ReadLine();

             // Задание 2.

             Console.WriteLine("Таблица умножения:");
             int no = 1;
             int nt = 1;
             int nine = 9;
             while (no < 10 && nt < 10)
             {
                 for (nt = 1; no < 10; nt++)
                 {
                     Console.WriteLine($"{no} * {nt} = {no * nt}");
                     if (nt == 9)
                     {
                         no++;
                         for (nt = 9; nt >= 1; nt--);

                     }
                     else if (no == 10 & nt == 10)
                     {
                        break;
                     }
                 }

             }

            Console.WriteLine("Нажмите Enter чтобы продолжить:");
            Console.ReadLine(); 

            // Задание 3.

            Console.WriteLine("Введите число x:");
             int x = Int32.Parse(Console.ReadLine());
             Console.WriteLine("Введите число y:");
             int y = Int32.Parse(Console.ReadLine());

             while (true)
             {
                 int xy = x;
                 for (xy = x;xy <= y; xy++)
                 {

                     if (xy % 5 == 0)
                     {
                         Console.WriteLine($"Число {xy} кратно 5");
                     }
                     else
                     {
                         Console.WriteLine($"Число {xy} не кратно 5");
                     }

                 }
                 break;
             }
             Console.WriteLine("Нажмите Enter чтобы продолжить:");
             Console.ReadLine();

             // Задание 4.

             Console.WriteLine("Введите число i:");
             string i = Console.ReadLine();
             int chars = i.Length;
             int ones = 0;
             int zeros = 0;

             foreach (char iif in i)
             {
                 if(iif == '1')
                 {
                     ones++;
                 }
                 else if (iif == '0')
                 {
                     zeros++;
                 }

             }
             Console.WriteLine($"Общее кол-во символов {chars}");
             Console.WriteLine($"Единиц - {ones}");
             Console.WriteLine($"Нулей - {zeros}");

             Console.WriteLine("Нажмите Enter чтобы продолжить:");
             Console.ReadLine();

            // Задание 5.

            Console.WriteLine("Введите сумму:");
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во месяцев:");
            double monthinput = double.Parse(Console.ReadLine());
            double stavka = 10;
            double month = 1;
            for (month = 1; month <= monthinput; month++)
            {
                double mfm = money / stavka;
                money += money * 0.1;
                
                Console.WriteLine($"{month}. Месячный платеж - {mfm}.");
                Console.WriteLine($"{month}. Общий остаток - {money}.");
            }

            Console.WriteLine("Нажмите Enter чтобы продолжить:");
            Console.ReadLine();

            // Задание 6.
            MM:
            Console.WriteLine("1. Авторизация");
            Console.WriteLine("2. О программе");
            Console.WriteLine("3. Выход");
            Console.WriteLine("Используйте цифры на клавиатуре как способ навигации.");
            int vvod = Int32.Parse(Console.ReadLine());    
            if (vvod == 1)
            {
                
                while (true)
                {
                    const int login = 2024;
                    const int password = 456123;
                    Console.WriteLine("Введите логин.");
                    int vvodlogin = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите пароль.");
                    int vvodpassword = Int32.Parse(Console.ReadLine());
                    if (login == vvodlogin && password == vvodpassword)
                    {
                        Console.WriteLine("Вы авторизованы!");
                        Avt:
                        Console.WriteLine("1. Продолжить.");
                        Console.WriteLine("2. Главное меню.");
                        int svl = Int32.Parse(Console.ReadLine());
                        if (svl == 1)
                        {
                            Console.WriteLine("Приложение еще находится в разработке.");
                            goto Avt;

                        }
                        else if (svl == 2)
                        {
                            goto MM;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверный логин или пароль.");
                    }
                }
                
            }
            else if (vvod == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Данная программа поможет Вам, активировать Ваш Windows.");
                Console.WriteLine("Программа была создана группой единомышленников, которые считают что цены на лицензию слишком завышены.");

                Console.WriteLine("1. Главное меню.");
                int vvodinfo = Int32.Parse(Console.ReadLine());
                if (vvodinfo == 1)
                {
                    goto MM;
                }
            }
            else if (vvod == 3)
            {
                Console.WriteLine("Закрытие приложения...");
            }

        }
    }
}