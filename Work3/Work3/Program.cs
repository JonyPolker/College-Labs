namespace Work3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1.

            Console.WriteLine("Введите число a:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            int b = Int32.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine($" {a} = {b}");
            }
            else if (a < b)
            {
                Console.WriteLine($" {a} < {b}");
            }
            else if (a > b)
            {
                Console.WriteLine($" {a} > {b}");
            }

            Console.WriteLine("Нажмите Enter чтобы продолжить.");
            Console.ReadLine();

            // Задание 2.

            Console.WriteLine("Введите число:");
            int N = Int32.Parse(Console.ReadLine());
            if (N % 2 == 0)
            {
                Console.WriteLine($"Число N - {N}, является четным");
            }
            else
            {
                Console.WriteLine($"Число N - {N}, не является четным");
            }

            Console.WriteLine("Нажмите Enter чтобы продолжить.");
            Console.ReadLine();

            // Задание 3.

            Console.WriteLine("Введите цену товара:");
            int cost = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во товара:");
            int kolvo = Int32.Parse(Console.ReadLine());
            int skidkax = 100;
            int skidkaxb = cost - 100;
            int skidkay = cost / 2;
            if (cost >= 500 && kolvo >= 1000)
            {
                Console.WriteLine($"Цена товара - {cost} рублей");
                Console.WriteLine($"Кол-во товара - {kolvo} единиц");
                Console.WriteLine($"Скидка - 100 рублей.");
                Console.WriteLine($"Итоговая цена - {skidkaxb} рублей.");

            }
            else if (cost > 100 && kolvo <= 100)
            {
                Console.WriteLine($"Цена товара - {cost} рублей");
                Console.WriteLine($"Кол-во товара - {kolvo} единиц");
                Console.WriteLine($"Скидка - {skidkay} рублей.");
                Console.WriteLine($"Итоговая цена - {skidkay} рублей.");


            }
            else
            {
                Console.WriteLine($"Цена товара - {cost} рублей");
                Console.WriteLine($"Кол-во товара - {kolvo} единиц");
                Console.WriteLine($"Скидки не будет");
                Console.WriteLine($"Итоговая цена - {cost} рублей.");
            }

            Console.WriteLine("Нажмите Enter чтобы продолжить.");
            Console.ReadLine();

            // Задание 4.

            const int fuel = 100;
            const int fuelcount5km = 1;
            const int fuelkm = 5;

            Console.WriteLine("Введите дистанцию в км: ");
            int dist = Int32.Parse(Console.ReadLine());

            int fuelneed = dist / fuelkm;
            int fuelleft = fuel - fuelneed;

            if (fuelleft >= 0)
            {
                Console.WriteLine($"Потрачено топлива: {fuelneed} литров.");
                Console.WriteLine($"Осталось топлива: {fuelleft} литров");
            }
            else
            {
                Console.WriteLine($"Потребуется топлива: {fuelneed} литров.");
                Console.WriteLine($"Нужно дозаправить: {Math.Abs(fuelleft)} литров");
            }

            Console.WriteLine("Нажмите Enter чтобы продолжить.");
            Console.ReadLine(); 

            // Задание 5.

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
                        Console.WriteLine("Нажмите Enter чтобы продолжить.");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неверный логин или пароль.");
                        Console.WriteLine("Нажмите Enter чтобы продолжить.");
                        Console.ReadLine();
                    }
                }

            }
            else if (vvod == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Данная программа поможет Вам, активировать Ваш Windows.");
                Console.WriteLine("Программа была создана группой единомышленников, которые считают что цены на лицензию слишком завышены.");

                Console.WriteLine("Нажмите Enter чтобы продолжить.");
                Console.ReadLine();
            }
        }
    }
}
