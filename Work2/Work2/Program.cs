namespace Work2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1.
            Console.WriteLine("Введите число \"X\"");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число \"Y\"");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} / {y} = {x / y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} % {y} = {x % y}");

            Console.WriteLine("Нажмите Enter чтобы продолжить.");
            Console.ReadLine();


            // Задание 2.
            int number = 0;
            Console.WriteLine($"{++number},{number++},{number--},{--number}");


            Console.WriteLine("Нажмите Enter чтобы продолжить.");
            Console.ReadLine();


            // Задание 3.
            int xthree = 1;
            int ythree = 2;
            int zthree = 3;

            int xfour = ythree - zthree * zthree;
            int yfour = ythree + zthree;
            int zfour = ythree * zthree;

            Console.WriteLine(xfour);
            Console.WriteLine(yfour);
            Console.WriteLine(zfour);


            Console.WriteLine("Нажмите Enter чтобы продолжить.");
            Console.ReadLine();


            // Задание 4.
            Console.WriteLine("Введите длину первого катета:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину второго катета:");
            double b = double.Parse(Console.ReadLine());
            double ap = Math.Pow(a, 2);
            double bp = Math.Pow(b, 2);
            double c = Math.Sqrt(ap + bp);
            Console.WriteLine($"Гипотенуза равна - {c}");
            Console.WriteLine("Нажмите Enter чтобы продолжить.");
            Console.ReadLine();


            // Задание 5.


            Console.WriteLine("Введите дистанцию:");
            float distance = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите расход топлива:");
            float fuelForDistance = float.Parse(Console.ReadLine());
            float totalFuelConsumption = distance * fuelForDistance;
            double tFC = Math.Ceiling(totalFuelConsumption);
            Console.WriteLine($"Общий расход равен - {tFC}.");
        }
    }
}
