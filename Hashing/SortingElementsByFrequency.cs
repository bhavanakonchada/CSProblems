using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace CSProblems.Hashing
{
    class SortingElementsByFrequency
    {
        public static void Main()
        {
            Console.WriteLine($"Given an array A[] of integers, sort the array according to frequency of elements." +
                $" That is elements that have higher frequency come first. If frequencies of two elements are same, " +
                $"then smaller number comes first.");

            var input = new int[] { 5, 5, 4, 6, 4, 9, 9, 9, 8 };
            Console.WriteLine($"input is {input}");

            //sort the array
            Array.Sort(input);

            var relativeDic = new Dictionary<int, int>();

            foreach (var item in input)
            {
                if (relativeDic.ContainsKey(item))
                {
                    relativeDic[item] = ++relativeDic[item];
                }
                else
                {
                    relativeDic[item] = 1;
                }
            }

            var outputDic = new Dictionary<int, List<int>>();

            foreach (var item in relativeDic)
            {
                if (outputDic.ContainsKey(item.Value))
                {
                    outputDic[item.Value].Add(item.Key);
                }
                else
                {
                    outputDic[item.Value] = new List<int>() { item.Key };
                }
            }

          var sortedOutput = outputDic.ToImmutableSortedDictionary().Reverse();

            foreach (var item in sortedOutput)
            {
                Print(item.Key, item.Value);
            }

            Console.ReadLine();
        }

        private static void Print(int key, List<int> value)
        {
            foreach (var item in value)
            {
                for(int i = 0; i < key; i++)
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
