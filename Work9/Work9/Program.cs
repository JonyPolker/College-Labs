namespace Work9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1-2.

            Unit unit = new Unit(150);

            unit.Damage(115);

            unit.Heal(75);
            unit.IncreaseHealth(450);

            Console.WriteLine();
            Console.WriteLine($"Для перехода, нажмите любую клавишу.");
            Console.ReadKey();

            // Task 3.

            Bank bank = new Bank(1);
            
            Console.WriteLine(bank.CheckSN);

            Console.WriteLine(bank.Money);

            Console.WriteLine($"Введите сумму, которую хотите установить на балансе:");
            int balance = int.Parse(Console.ReadLine());
            bank.Money = balance;
            Console.WriteLine($"Баланс пополнен на {balance} руб.");

            Console.WriteLine($"{bank.Status}");

            bank.Switch();
            bool ST = bank.ST;
            if (ST == true)
            {
                Console.WriteLine($"Банкомат включен");
            }
            else if (ST == false)
            {
                Console.WriteLine($"Банкомат выключен");
            }

        }
    }
}
