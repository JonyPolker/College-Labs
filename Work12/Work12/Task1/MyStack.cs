using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work12.Task1
{
    internal class MyStack<T>
    {
        private T[] items;
        public T[] Items => items;

        public MyStack()
        {
            items = new T[0];
        }

        public void Push(T newitem)
        {
            var olditems = items;
            items = new T[olditems.Length + 1];

            for(int i = 0; i < olditems.Length; i++)
            {
                items[i] = olditems[i];
            }

            items[^1] = newitem;
        }

        public T Pop()
        {
            T tempitem = items[^1];
            var olditems = items;
            items = new T[olditems.Length-1];
            for(int i = 0; i < items.Length; i++)
            {
                items[i] = olditems[i];
            }
            return tempitem;
        }

        public void isEmpty()
        {
            if (items.Length > 0)
            {
                Console.WriteLine("В массиве есть элементы");
                return;
            }
            Console.WriteLine("В массиве нету элементов");
        }
    }
}
