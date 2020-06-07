using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.DivideAndConquer
{
    class SearchInARotatedArray
    {
        public static void Main()
        {
            Console.WriteLine($"Given a sorted and rotated array A of N distinct elements which is rotated at some point," +
                $" and given an element K. " +
                $"The task is to find the index of the given element K in the array A.");

            var input = new int[] { 5, 6, 7, 8, 9, 10, 1, 2, 3 };
            //int result;

            // K is what we are looking for
            int K = 10;

            int result = SearchRotated(input, 0, input.Length - 1, K);

            Console.WriteLine($"The element in this array is {result}");

            //Console.WriteLine($"The element that is not repeated in this array is {result}");

            Console.ReadLine();
        }

        private static int SearchRotated(int[] input, int start, int end, int K)
        {
            if (start > end)
            {
                return -1;
            }

            if (start == end)
            {
                Console.WriteLine("The required element is "
                                                 + input[start]);
                return input[start];
            }

            int mid = (start + end) / 2;

            if (input[mid] == K)
            {
                return mid;
            }               

            // if left part is sorted
            if (input[start] < input[mid])
            {
                //check if element is in range
                if (input[start] <= K && input[mid] >= K)
                {
                    //look in the left side
                    return SearchRotated(input, start, mid, K);
                }
                else
                {
                    return SearchRotated(input, mid + 1, end, K);
                }
            }
            else
            {
                //if right part is sorted
                if (input[mid] <= K && input[mid + 1] >= K)
                {
                    return SearchRotated(input, mid + 1, end, K);
                }
                else
                {
                    return SearchRotated(input, start, mid, K);
                }
            }
        }
    }
}
