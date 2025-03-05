using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Work11.Task3
{
    internal class ResourceStorage
    {
        private int _money = 500;
        private int _wood = 500;
        private int _iron = 500;

        public int Money
        {
            get 
            {
                return _money;
            }
            set
            {
                _money = Math.Clamp (value, 0, 500);
            }
        }
        public int Wood
        {
            get
            {
                return _money;
            }
            set
            {
                _money = Math.Clamp(value, 0, 500);
            }
        }
        public int Iron
        {
            get
            {
                return _money;
            }
            set
            {
                _money = Math.Clamp(value, 0, 500);
            }
        }
        public int DisplayResource(int num)
        {
            if (num == 1)
            {
                return Money;
            }
            else if (num == 2)
            {
                return Wood;
            }
            else if (num == 3)
            {
                return Iron;
            }
            return 0;
        }
        public bool TryGetWood(int amount)
        {
            if (_wood - amount < 0)
            {
                Console.WriteLine($"У Вас не хватает дерева, необходимо  - {amount} дерева, у Вас имеется - {_wood}.");
                return false;
            }
            else
            {
                Console.WriteLine($"Операция успешно совершена, было использовано {amount} дерева, осталось - {_wood}.");
                return true;
            }
        }
        public bool TryGetMoney(int amount)
        {
            if (_money - amount < 0)
            {
                Console.WriteLine($"У Вас не хватает денег, необходимо  - {amount} золотых, у Вас имеется - {_money}");
                return false;
            }
            else
            {
                Console.WriteLine($"Операция успешно совершена, было списано {amount} золотых, осталось - {_money}");
                return true;
            }
        }
        public bool TryGetIron(int amount)
        {
            if (_iron - amount < 0)
            {
                Console.WriteLine($"У Вас не хватает железа, необходимо  - {amount} железа, у Вас имеется - {_iron}.");
                return false;
            }
            else
            {
                Console.WriteLine($"Операция успешно совершена, было использовано {amount} железа, осталось - {_iron}.");
                return true;
            }
        }

    }
}
