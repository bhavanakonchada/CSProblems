using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Arrays
{
    class PermutationsOfArray
    {
        public static void Main()
        {
            Console.WriteLine("Printing all permutations of a given input [1,3,5]");

            FindPermutations(new int[] {1,3,5});
        }

        private static void FindPermutations(int[] input)
        {
            List<List<int>> result = new List<List<int>>();
            Queue<List<int>> perms = new Queue<List<int>>();
            perms.Enqueue(new List<int>());

            for (int i = 0; i < input.Length; i++)
            {
                int n = perms.Count;
                for (int j = 0; j < n; j++)
                {
                    var oldPerm = perms.Dequeue();
                    for (int k = 0; k <= oldPerm.Count; k++)
                    {
                        var newPerm = new List<int>(oldPerm);
                        newPerm.Insert(k, input[i]);

                        if(newPerm.Count == input.Length)
                        {
                            result.Add(newPerm);
                        }
                        else
                        {
                            perms.Enqueue(newPerm);
                        }
                    }
                }
            }

            //Print the subsets
            foreach (var item in result)
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
