using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace CSProblems.Hashing
{
    class RelativeSorting
    {
        public static void Main()
        {
            Console.WriteLine($"Given two arrays A1[] and A2[] of size N and M respectively. " +
                $"The task is to sort A1 in such a way that the relative order among the elements" +
                $" will be same as those in A2. For the elements not present in A2, append them" +
                $" at last in sorted order. It is also given that the number of elements in A2[] " +
                $"are smaller than or equal to number of elements in A1[] and A2[] has all distinct elements.");

            var A1 = new int[] { 2, 1, 2, 5, 7, 1, 9, 3, 6, 8, 8 };
            var A2 = new int[] { 2, 1, 8, 3 };

            var relativeDic = new Dictionary<int, int>();
            foreach (var item in A2)
            {
                relativeDic.Add(item, 0);
            }

            var absDic = new Dictionary<int, int>();

            foreach (var item in A1)
            {
                if (relativeDic.ContainsKey(item))
                {
                    relativeDic[item]= ++relativeDic[item];
                }
                else if (absDic.ContainsKey(item))
                {
                    absDic[item] = ++absDic[item];
                }
                else
                {
                    absDic[item] = 1;
                }
            }

            Console.WriteLine("Printing relative sort for A1");
            foreach (var item in relativeDic)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    Console.Write($"{item.Key} ");
                }
            }

            foreach (var item in absDic.ToImmutableSortedDictionary())
            {
                for (int i = 0; i < item.Value; i++)
                {
                    Console.Write($"{item.Key} ");
                }
            }

            Console.ReadLine();
        }
    }
}
