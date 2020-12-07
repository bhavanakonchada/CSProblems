using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Arrays
{
    class DutchNationalFlagProblem
    {
        public static void Main()
        {
            Console.WriteLine("3 way grouping of elements in an array");
            Console.WriteLine($"Assume input is 45,34,76,12,1,2,4,6,76,54,89,21 and we need to group them as : elements < 10, elements between 10 and 30 and elements greater than 30");
            ThreeWayOrdering(new int[] { 45, 34, 76, 12, 1, 2, 4, 6, 76, 54, 89, 21 });

            Console.ReadLine();
        }

        private static void ThreeWayOrdering(int[] input)
        {
            int low = 10;
            int mid = 30;
            int high = 31;

            int i = 0, j = 0;
            int k = input.Length - 1;

            while ( j <= k)
            {
                if(input[j] < mid)
                {
                    //swap
                    var temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;

                    i++;
                    j++;
                }
                else if (input[j] > mid)
                {
                    //swap
                    var temp = input[j];
                    input[j] = input[k];
                    input[k] = temp;

                    k = k - 1;
                }
                else
                {
                    j++;
                }
            }

            ArrayPrinter.Print(input);
        }
    }
}
