using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace CSProblems.Arrays
{
    class SubArrayWithGivenSum
    {
        public static void Main()
        {
            Console.WriteLine("Given a array, find a sub array (contiguous) with a given sum");

            //input array
            int[] input = new int[] { 2, 3, 4, 6, 2,2 };  //new int[] { 2, 3, 4, 6, 2, 4, 5, 7, 3 };

            int givenSum = 10;

            //Method 1 - O(n^2) time complexity - without sorting
            for (int i = 0; i < input.Length-1; i++)
            {
                int j = i + 1;
                int tempResult = input[i];
                while ((tempResult < givenSum) && j < input.Length)
                {
                    tempResult += input[j];
                    if (tempResult == givenSum)
                    {
                        Console.WriteLine($"Found given sum between indices:{i} and {j}");
                    }
                    j++;
                }
            }
            
            Console.ReadLine();
        }
    }
}
