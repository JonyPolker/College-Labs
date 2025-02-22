/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work8
{
    internal class Rezerv
    {
        int menu = 0;
            while (menu != 5)
            {
                Console.Clear();
                Console.WriteLine("1. Увеличить баланс.");
                Console.WriteLine("2. Уменьшить баланс.");
                Console.WriteLine("3. Перевод другому гр-ну.");
                Console.WriteLine("4. Просмотр баланса.");
                Console.WriteLine("5. Выход.");
                Console.WriteLine("Для навигации используйте цифры:");
                menu = Int32.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    Console.Clear();
                    for (int i = 0; i< 2; i++)
                    {
                        Console.WriteLine($"{i + 1}. {B.owner[i]}");
                    }
    Console.WriteLine("Выберите гр-нина для увеличения баланса.");
                    int input = Int32.Parse(Console.ReadLine());
    Console.Clear();
                    input--;
                    Console.WriteLine("Введите сумму на которую хотите увеличить баланс.");
                    decimal AM = Decimal.Parse(Console.ReadLine());
    Bank.AddMoney(AM);
                    Console.Clear();
                    Console.WriteLine($"Баланс увеличен на - {AM} рублей");
                    Console.WriteLine($"Баланс - {} рублей");
                    Console.WriteLine("Нажмите любую клавишу для продолжения.");
                    Console.ReadKey();
                }
                else if (menu == 2)
{
    Console.Clear();
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine($"{i + 1}. {B.owner[i]}"); ;
    }
    Console.WriteLine("Выберите гр-нина для увеличения баланса.");
    int input = Int32.Parse(Console.ReadLine());
    Console.Clear();
    input--;
    Console.WriteLine("Введите сумму на которую хотите увеличить баланс.");
    decimal AM = Decimal.Parse(Console.ReadLine());
    B.Remove(input, AM);
    Console.Clear();

    Console.WriteLine($"Баланс уменьшен на - {AM} рублей");
    Console.WriteLine($"Баланс - {} рублей");
    Console.WriteLine("Нажмите любую клавишу для продолжения.");
    Console.ReadKey();
}
else if (menu == 3)
{
    Console.Clear();
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine($"{i + 1}. {}"); ;
    }
    Console.WriteLine("Выберите гражданина от которого будет осуществляться перевод.");
    int input = Int32.Parse(Console.ReadLine());
    Console.Clear();
    input--;
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine($"{i + 1}. {}"); ;
    }
    Console.WriteLine("Выберите гражданина, которому будет осуществлен перевод.");
    int input2 = Int32.Parse(Console.ReadLine());
    Console.Clear();
    input2--;
    Console.WriteLine("Введите сумму которую хотите перевести.");
    decimal summa = Decimal.Parse(Console.ReadLine());
    B.SendMoney(input, input2, summa);
    Console.Clear();
    Console.WriteLine($"Сумма перевода - {summa} рублей");
    Console.WriteLine($"Баланс отправителя средств - {} рублей");
    Console.WriteLine($"Баланс получателя средств - {} рублей");
    Console.WriteLine("Нажмите любую клавишу для продолжения.");
    Console.ReadKey();
}
else if (menu == 4)
{
    Console.Clear();
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine($"{i + 1}. {B.owner[i]}"); ;
    }
    Console.WriteLine("Выберите гр-нина, у которого хотите просмотреть баланс.");
    int input = Int32.Parse(Console.ReadLine());
    Console.Clear();
    input--;
    Console.WriteLine($"Баланс - {B.balance[input]} рублей");
    Console.WriteLine("Нажмите любую клавишу для продолжения.");
    Console.ReadKey();
}
            }
    }
}
*/