using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Arrays
{
    class CountTheTriplet
    {
        public static void Main()
        {
            Console.WriteLine("Given a array, find a sub array (contiguous) with a given sum");

            //input array
            int[] input = new int[] { 2, 4, 7, 9, 3, 8, 6 };  //new int[] { 2, 3, 4, 6, 2, 4, 5, 7, 3 };

           // int givenSum = 10;

            //Method 1 - O(n^2) time complexity - without sorting
            //for (int i = 0; i < input.Length - 1; i++)
            //{
            //    int j = i + 1;
            //    int tempResult = input[i];
            //    while ((tempResult < givenSum) && j < input.Length)
            //    {
            //        tempResult += input[j];
            //        if (tempResult == givenSum)
            //        {
            //            Console.WriteLine($"Found given sum between indices:{i} and {j}");
            //        }
            //        j++;
            //    }
            //}

            //Method 2 - sorted array
            Array.Sort(input);

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (i != j)
                    {
                        var desiredSum = input[i] + input[j];

                        var foundSum = Array.BinarySearch(input, desiredSum);
                        if (foundSum > 0)
                        {
                            Console.WriteLine($"Found a triplet : {input[i]}, {input[j]} and {desiredSum}");
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
