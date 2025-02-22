using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work8
{
    internal class Bank
    {
        public decimal balance;
        public string name;

        public Bank(decimal NewBalance, string NewName)
        {
            balance = NewBalance;
            name = NewName;
        }
        public string owner;

        public void AddMoney(decimal AM)
        {
            Console.Clear();
            Console.WriteLine($"Баланс пополнен на {AM} рублей.");
        }
        public void Remove(decimal RM)
        {
            Console.Clear();
            if (balance >= RM)
            {
                Console.WriteLine($"С баланса списано {RM} рублей.");
            }
            else
            {
                Console.WriteLine($"На счете недостаточно средств!");
            }
        }
        public void SendMoney(decimal SM, Bank user1)
        {
            Console.Clear();
            balance -= SM;
            user1.balance += SM;
            Console.WriteLine($"Вы перевели пользователю {user1.name} - {SM} рублей.");
        }

    }
}
