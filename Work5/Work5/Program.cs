namespace Work5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1.

            Console.WriteLine("Введите длину массива:");
            int N = Int32.Parse(Console.ReadLine());
            int[] massiv = new int[N];
            for (int i = 0; i < N; i++)
            {
                massiv[i] = i * 2;
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"massiv [{i}] = {massiv[i]}");
            }

            Console.WriteLine("Нажмите Enter чтобы продолжить:");
            Console.ReadLine();

            // Задание 2.
            string[] numss = { "Сергей", "Саид", "Даниил", "Кирилл", "Домиан", "Илья" };
            int Ligh = numss.Length;
            int nn = 1;
            int it = 0;
            while (it < Ligh)
            {
                Console.WriteLine($"{nn}. {numss[it]}");
                nn++;
                it++;
            }

            Console.WriteLine("Нажмите Enter чтобы продолжить:");
            Console.ReadLine();

            // Задание 3.

            int ith = 0;
            double[] numcc = { 9.81, 1.43, 3.14, 5.3, 9.9 };
            double NML = numcc.Length;
            double start = 1;
            double sum = start;
            while (ith < NML)
            {
                start += numcc[ith];
                ith++;
            }
            Console.WriteLine($"Сумма цифр - {start}.");

            Console.WriteLine("Нажмите Enter чтобы продолжить:");
            Console.ReadLine();

            // Задание 4.

            Console.WriteLine("Введите название товара:");
            string nameo = Console.ReadLine();
            Console.WriteLine("Введите кол-во товара:");
            double kolvoo = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость товара:");
            double costo = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите название товара:");
            string nametw = Console.ReadLine();
            Console.WriteLine("Введите кол-во товара:");
            double kolvotw = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость товара:");
            double costtw = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите название товара:");
            string nameth = Console.ReadLine();
            Console.WriteLine("Введите кол-во товара:");
            double kolvoth = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость товара:");
            double costth = double.Parse(Console.ReadLine());

            string[] name = { nameo, nametw, nameth };
            double[] kolvo = { kolvoo, kolvotw, kolvotw };
            double[] cost = { costo, costtw, costth };

            Console.WriteLine("Нажмите Enter чтобы перейти к списку.");
            Console.ReadLine();

            Console.WriteLine("Выберите товар из списка:");
            Console.WriteLine($"1.{nameo}.");
            Console.WriteLine($"2.{nametw}.");
            Console.WriteLine($"3.{nameth}.");
            Console.WriteLine("Для навигации используйте цифры на клавиатуре.");

            int inputname = Int32.Parse(Console.ReadLine());
            --inputname;
            Console.WriteLine($"Наименование - {name[inputname]}.");
            Console.WriteLine($"Кол-во - {kolvo[inputname]} шт.");
            Console.WriteLine($"Цена - {cost[inputname]} рублей.");

            Console.WriteLine("Нажмите Enter чтобы продолжить:");
            Console.ReadLine();

            // Задание 5.
            int io = 0;
            string[] naimen = { "Квас Очаковский", "Кириешки", "Венский Конвертик" };
            string[] opisanie = { "Отлично утоляет жажду в жаркую погоду.", "Вкусные сухари за символическую плату.", "Вкусное хлебное изделие." };
            double[] sklad = { 26, 74, 52 };
            double[] cena = { 99, 15, 60 };
            Console.WriteLine("Добро пожаловать в интернет-магазин компании ООО\"Тмыв денег\"");
            Console.WriteLine("Список товаров доступный для покупки:");
            Console.WriteLine($"1. {naimen[0]}");
            Console.WriteLine($"2. {naimen[1]}");
            Console.WriteLine($"3. {naimen[2]}");
            Console.WriteLine("Выберите товар чтобы узнать о нем больше информации.");
            int inputtov = Int32.Parse(Console.ReadLine());
            if (inputtov > 0 & inputtov < 4)
            {
                --inputtov;
                Console.WriteLine($"Наименование товара - {naimen[inputtov]}.");
                Console.WriteLine($"Описание: {opisanie[inputtov]}");
                Console.WriteLine($"Кол-во на складе - {sklad[inputtov]}.");
                Console.WriteLine($"Стоимость - {cena[inputtov]} рублей.");
            }

            Console.WriteLine("Нажмите Enter чтобы продолжить:");
            Console.ReadLine();

            // Задание 6.

            Console.WriteLine("Введите название товара:");
            string nameos = Console.ReadLine();
            Console.WriteLine("Введите кол-во товара:");
            int kolvoos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость товара:");
            int costos = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите название товара:");
            string nametws = Console.ReadLine();
            Console.WriteLine("Введите кол-во товара:");
            int kolvotws = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость товара:");
            int costtws = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите название товара:");
            string nameths = Console.ReadLine();
            Console.WriteLine("Введите кол-во товара:");
            int kolvoths = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость товара:");
            int costths = Int32.Parse(Console.ReadLine());

            string[] names = { nameos, nametws, nameths };
            int[] kolvos = { kolvoos, kolvotws, kolvotws };
            int[] costs = { costos, costtws, costths };
            int[] skidka = { 100, 200 };
            Console.WriteLine("Нажмите Enter чтобы перейти к списку.");
            Console.ReadLine();

            Console.WriteLine("Выберите товар из списка:");
            Console.WriteLine($"1. {nameos}.");
            Console.WriteLine($"2. {nametws}.");
            Console.WriteLine($"3. {nameths}.");
            Console.WriteLine("Для навигации используйте цифры на клавиатуре.");

            int inputnames = Int32.Parse(Console.ReadLine());
            --inputnames;
            Console.WriteLine($"Наименование - {names[inputnames]}.");
            Console.WriteLine($"Кол-во - {kolvos[inputnames]}.");
            if (costs[inputnames] > skidka[1] & kolvos[inputnames] > skidka[0])
            {
                Console.WriteLine($"Цена - {costs[inputnames]}");
                Console.WriteLine("Скидка составит - 100 рублей.");
                Console.WriteLine($"Итоговая цена - {costs[inputnames] - 100} рублей.");
            }
            else
            {
                Console.WriteLine($"Цена - {costs[inputnames]} рублей.");
            }

            Console.WriteLine("Нажмите Enter чтобы продолжить:");
            Console.ReadLine();
        }
    }
}
