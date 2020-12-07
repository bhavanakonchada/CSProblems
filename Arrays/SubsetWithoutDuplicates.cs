using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Arrays
{
    class SubsetWithoutDuplicates
    {
        public static void Main()
        {
            Console.WriteLine("Print all subsets of a given input : 1,3,5");

            SubsetFinder(new int[] { 1, 3, 5 });

            Console.ReadLine();

        }

        private static void SubsetFinder(int[] input)
        {
            List<List<int>> subsets = new List<List<int>>();
            subsets.Add(new List<int>());

            for (int i = 0; i < input.Length; i++)
            {
                int n = subsets.Count;
                for (int j = 0; j < n; j++)
                {
                    //take the subset one by one - copy and add
                    var currentSubset = new List<int> (subsets[j]);
                    currentSubset.Add(input[i]);
                    subsets.Add(currentSubset);
                }
            }

            Console.WriteLine(subsets);

            //Print the subsets
            foreach (var item in subsets)
            {
                Console.Write("[ ");
                for (int i = 0; i < item.Count; i++)
                {
                    Console.Write(item[i] + " ");
                }

                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}
