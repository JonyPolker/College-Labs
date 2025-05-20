using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static public void Main()
        {
            List<int> list = new List<int> { 52, 29, 65 };

            int menu = 0;
            while (menu != 0)
            {

            }
        }

        static internal void  AllOut(List<int> list)
        {
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        static internal List<int> RemoveElement(List<int> list, int num)
        {
            list.RemoveAt(num);
            return list;
        }

        static internal List<int> AddLast(List<int> list, int num)
        {
            LinkedList<int> llist = new LinkedList<int>(list);
            llist.AddFirst(num);
            List<int> newlist = new List<int>();
            var ind = llist.First;
            int i = 0;
            while (ind != null)
            {
                newlist[i] = ind.Value;
                i++;
                ind = ind.Next;
            }
            return newlist;
        }

        static internal List<int> AddToUse(List<int> list, int num, int pos)
        {
            LinkedList<int> llist = new LinkedList<int>(list);
            llist.AddFirst(num);
            List<int> newlist = new List<int>();
            
            
            return newlist;
        }

        static internal List<int> RemoveAll(List <int> list)
        {
            list.Clear();
            return list;
        }

        static internal int Summary(List <int> list)
        {
            int sum = 0;
            return sum;
        }

    }
}