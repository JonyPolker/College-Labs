using System.Runtime.CompilerServices;

namespace Work14
{
    internal class Program
    {
        static Dictionary<string, ConsoleColor> colors = new Dictionary<string, ConsoleColor>()
        {
            {"Красный", ConsoleColor.Red},
            {"Синий", ConsoleColor.Blue},
            {"Белый", ConsoleColor.White}
        };
        static Stack<ConsoleColor> cannon = new Stack<ConsoleColor>();

        static string shot = "БАААААААААААААААМ!";
        static public void Main()
        {
            // Task 1

            List<int> list = new List<int> { 52, 29, 65 };

            int menu = 0;
            int elem = 0;
            while (menu != 10)
            {
                Console.Clear();
                Console.WriteLine("1. Вывести все елементы");
                Console.WriteLine("2. Удалить элемент по его порядковому номеру");
                Console.WriteLine("3. Добавить элемент в конец списка");
                Console.WriteLine("4. Добавить элемент в начало списка");
                Console.WriteLine("5. Добавить элемент в указанное место");
                Console.WriteLine("6. Очистить список");
                Console.WriteLine("7. Найти сумму всех элементов");
                Console.WriteLine("8. Найти количество четных элементов");
                Console.WriteLine("9. Найти количество нечетных элементов");
                Console.WriteLine("10. Выход");
                Console.WriteLine("Для управления используйте клавиатуру.");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        AllOut(list);
                        Console.WriteLine();
                        Stop();
                        break;

                    case 2:
                        Console.Clear();
                        AllOut(list);
                        Console.WriteLine();
                        Console.WriteLine("Выберите элемент который хотите удалить.");
                        elem = int.Parse(Console.ReadLine());
                        Console.Clear();
                        list = RemoveElement(list, elem-1);
                        break;

                    case 3:
                        Console.Clear();
                        AllOut(list);
                        Console.WriteLine();
                        Console.WriteLine("Введите элемент, который хотите добавить:");
                        elem = int.Parse(Console.ReadLine());
                        Console.Clear();
                        list = AddToLast(list, elem);
                        break;

                    case 4:
                        Console.Clear();
                        AllOut(list);
                        Console.WriteLine();
                        Console.WriteLine("Введите элемент, который хотите добавить:");
                        elem = int.Parse(Console.ReadLine());
                        Console.Clear();
                        list = AddToStart(list, elem);
                        break;

                    case 5:
                        Console.Clear();
                        AllOut(list);
                        Console.WriteLine();
                        Console.WriteLine("Введите элемент, который хотите добавить:");
                        elem = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Введите место, на которое хотите поставить элемент:");
                        int pos = int.Parse(Console.ReadLine());
                        list = AddToPosit(list, elem, pos-1);
                        break;

                    case 6:
                        Console.Clear();
                        list = RemoveAll(list);
                        Console.WriteLine("Список был очищен.");
                        Stop();
                        break;

                    case 7:
                        Console.Clear();
                        int sum = Summary(list);
                        Console.WriteLine($"Сумма элементов - {sum}");
                        Stop();
                        break;

                    case 8:
                        Console.Clear();
                        int even = EvenNum(list);
                        Console.WriteLine($"Количество четных элементов - {even}");
                        Stop();
                        break;

                    case 9:
                        Console.Clear();
                        int odd = OddNum(list);
                        Console.WriteLine($"Количество нечетных элементов - {odd}");
                        Stop();
                        break;

                    case 10:
                        Console.Clear();
                        break;

                }
            }

            // Task 2

            Dictionary<string, string> country = new Dictionary<string, string>()
            {
                {"Россия", "Ефимов С.В."} // Да-да, вот такие планы.
            };

            int cmenu = 0;
            while (cmenu != 5)
            {
                Console.Clear();
                Console.WriteLine("1. Вывести страну и президента");
                Console.WriteLine("2. Добавить страну с президентом");
                Console.WriteLine("3. Изменить президента у страны");
                Console.WriteLine("4. Удалить страну");
                Console.WriteLine("5. Выход");
                Console.WriteLine("Для управления используйте клавиатуру.");
                cmenu = int.Parse(Console.ReadLine());

                switch(cmenu)
                {
                    case 1:
                        Console.Clear();
                        OutputCountry(country);
                        Stop();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Введите страну которую хотите добавить: ");
                        string count = Console.ReadLine();
                        Console.Clear();
                        Console.Write($"Введите президента которого хотите добавить для страны \"{count}\": ");
                        string pres = Console.ReadLine();
                        Console.Clear();
                        country = InputCountry(country, count, pres);
                        Console.WriteLine($"Президент {pres} был успешно добавлен стране - {count}.");
                        Stop();
                        break;

                    case 3:
                        Console.Clear();
                        OutputCountry(country);
                        Console.Write("Впишите страну из списка, у которой хотите изменить президента: ");
                        string countS = Console.ReadLine();
                        Console.Clear();
                        Console.Write($"Введите нового президента для страны \"{countS}\": ");
                        string newpres = Console.ReadLine();
                        Console.Clear();
                        country = ReplacePresident(country, countS, newpres);
                        Console.WriteLine($"Для страны {countS} был установлен президент - {newpres}");
                        Stop();
                        break;

                    case 4:
                        Console.Clear();
                        OutputCountry(country);
                        Console.Write("Впишите страну из списка, которую хотите удалить: ");
                        string countRem = Console.ReadLine();
                        country = RemoveCountry(country, countRem);
                        Console.Clear();
                        Console.WriteLine($"Страна \"{countRem}\" была удалена.");
                        Stop();
                        break;

                    case 5:
                        Console.Clear();
                        break;

                }
            }

            // Task 3

            var colorm = 0;

            while (colorm != 3)
            {
                Console.Clear();
                Console.WriteLine("1. Указать цвет для пушки");
                Console.WriteLine("2. Запустить пушку");
                Console.WriteLine("3. Выход");
                Console.WriteLine("Для управления используйте клавиатуру.");
                colorm = int.Parse(Console.ReadLine());

                switch(colorm)
                {
                    case 1:
                        Console.Clear();
                        foreach(var (text, color) in colors)
                        {
                            Console.WriteLine(text);
                        }
                        Console.Write("Введите цвет для пушки из вышеперечисленных: ");
                        string colorIn = Console.ReadLine();
                        Load(colorIn);
                        break;

                    case 2:
                        Console.Clear();
                        Salute();
                        break;

                    case 3:
                        Console.Clear();
                        break;
                }
            }
        }

        static internal void Load(string inputCol)
        {
            ConsoleColor color;
            colors.TryGetValue(inputCol, out color);
            cannon.Push(color);
        }

        static internal void Fire()
        {
            Console.ForegroundColor = cannon.Pop();
            Console.WriteLine(shot);
        }
        static internal void Salute()
        {
            int i = 0;
            while (cannon.Count > 0)
            {
                Fire();
                i++;
            }
            Console.ForegroundColor = ConsoleColor.White;
            if (i != 0)
            {
                Console.WriteLine();
            }
            Console.WriteLine("У пушки закончились снаряды.");
            Console.WriteLine();
            Stop();
        }

        static internal void OutputCountry(Dictionary<string, string> country)
        {
            foreach (var (count, pres) in country) Console.WriteLine($"Страна - {count}. Президент - {pres}");
        }

        static internal Dictionary<string, string> InputCountry(Dictionary<string, string> country, string count, string pres)
        {
            country.Add(count, pres);
            return country;
        }

        static internal Dictionary<string, string> ReplacePresident(Dictionary<string, string> country, string countS, string newpres)
        {
            country[countS] = newpres;
            return country;
        }

        static internal Dictionary<string, string> RemoveCountry(Dictionary<string, string> country, string countRem)
        {
            Dictionary<string, string> NewWorld = new Dictionary<string, string>();

            foreach (var (count, pres) in country)
            {
                if (count != countRem)
                {
                    NewWorld.Add(count, pres);
                }
            }
            return NewWorld;
        }

        static public void Stop()
        {
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.ReadKey();
        }

        static internal void AllOut(List<int> list)
        {
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        static internal List<int> RemoveElement(List<int> list, int num)
        {
            List<int> llist = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != num)
                {
                    llist.Add(list[i]);
                }
                else if (i == num)
                {
                    
                }
            }
            return llist;
        }

        static internal List<int> AddToLast(List<int> list, int elem)
        {
            list.Add(elem);
            return list;
        }

        static internal List<int> AddToStart(List<int> list, int elem)
        {
            List<int> llist = new List<int>();
            llist.Add(elem);
            for (int i = 0; i < list.Count; i++)
            {
                llist.Add(list[i]);
            }
            return llist;
        }

        static internal List<int> AddToPosit(List<int> list, int elem, int pos)
        {
            List<int> llist = new List<int>();
            int n = 0;
            for(int i = 0; i <= list.Count; i++)
            {
                if(i != pos)
                {
                    llist.Add(list[n]);
                    n++;
                }
                else if(i == pos)
                {
                    llist.Add(elem);
                }
            }
            return llist;
        }

        static internal List<int> RemoveAll(List<int> list)
        {
            list.Clear();
            return list;
        }

        static internal int Summary(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            return sum;
        }

        static internal int EvenNum(List<int> list)
        {
            int count = 0;

            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                    count++;
            }
            return count;
        }

        static internal int OddNum(List<int> list)
        {
            int count = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                    count++;
            }
            return count;
        }
    }
}
