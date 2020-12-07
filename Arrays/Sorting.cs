using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace CSProblems.Arrays
{
    public class ArraySorting
    {
        public static void Main()
        {
            int[] input = new int[] { 23, 43, 5, 12, 89, 23, 18, 9, 38 };

            Console.WriteLine($"Printing input array:");
            //After the each iteration, the array looks like:
            PrintArray(input);

            //SortInNSquareTime(input);

            SortInNLogNTime(input, 0, input.Length - 1);

            Console.ReadLine();
        }

        public static void PrintArray(int[] input)
        {
            for (int k = 0; k < input.Length; k++)
            {
                Console.Write(input[k] + " ");
            }
            Console.WriteLine();
        }

        private static void SortInNSquareTime(int[] input)
        {
            //Find the best possible way to sort this...
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        //swap them
                        int temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }

                Console.WriteLine($"Printing array after iteration {i}:");
                //After the each iteration, the array looks like:
                for (int k = 0; k < input.Length; k++)
                {
                    Console.Write(input[k] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[] SortInNLogNTime(int[] input, int start, int end)
        {
            if (start == end)
            {
                var output = new int[1];
                output[0] = input[start];

                return output;
            }
            int mid = (end + start) / 2;
            return Merge(SortInNLogNTime(input, start, mid), SortInNLogNTime(input, mid + 1, end));
        }

        private static int[] Merge(int[] inputA, int[] inputB)
        {
            int a = 0;
            int b = 0;
            int i = 0;

            Console.WriteLine("Merge called with inputs:");
            PrintArray(inputA);
            PrintArray(inputB);
            Console.WriteLine();

            int[] output = new int[inputA.Length + inputB.Length];

            while (a < inputA.Length && b < inputB.Length)
            {
                if (inputA[a] <= inputB[b])
                {
                    output[i] = inputA[a];
                    i++;
                    a++;
                }
                else if (inputB[b] <= inputA[a])
                {
                    output[i] = inputB[b];
                    b++;
                    i++;
                }
            }

            if (a == inputA.Length || b == inputB.Length) // items of one of the inputs are covered
            {
                //navigate thru all of remaining in inputB and include in the array
                if (a < inputA.Length)
                {
                    while (a < inputA.Length)
                    {
                        output[i] = inputA[a];
                        a++;
                        i++;
                    }
                }
                else
                {
                    while (b < inputB.Length)
                    {
                        output[i] = inputB[b];
                        b++;
                        i++;
                    }
                }
            }

            Console.WriteLine("Printing output after each merge");
            PrintArray(output);
            Console.WriteLine();

            return output;
        }
    }
}


/*
 *  int[] input = new int[] { 23, 43, 5, 12, 89, 23, 18, 9 };
 *  Is there something called Binary sort ?
 *  
 *  Even number of items example
 *  23,43,5,12    89,23,18,9
 *  23,43,  5,12    89,23   18,9
 *  23  43  5  12  89  23  18   9
 *  23,43,  5,12  23,89   9,18
 *  5,12,23,43     9,18,23,89   (starting from the left, compare each item and pick from each, to merge into a final list)
 *  
 *  5,9,12,18,23,23,43,89
 *  
 *  Odd Number example
 *  
 *  23,43,5,12,89,23,18,9,38
 *  23,43,5,12,89 ,23,18,9,38
 *  23,43,5    12,89   23,18   9,38
 *  23,43  5   12   89  23  18  9  38
 *  23  43  5   12   89  23  18  9  38
 *  23,43   5   12,89    18,23   9,38
 *  5,23,43     12,89     9, 18,23,38
 *  5,12,23,43,89     9,18,23,38
 *  
 *  5,9,12,18,23,23,38,43,89
 */
