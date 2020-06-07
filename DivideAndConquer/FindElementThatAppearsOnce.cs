using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.DivideAndConquer
{
    class FindElementThatAppearsOnce
    {
        public static void Main()
        {
            Console.WriteLine($"Given a sorted array A, size N, of integers; every element appears twice except for one. " +
                $"Find that element that appears once in array.");

            var input = new int[] { 1, 1, 2, 2, 3, 3, 4, 50, 50, 65, 65 };
            //int result;

            FindElement(input, 0, input.Length-1);


            //Console.WriteLine($"The element that is not repeated in this array is {result}");

            Console.ReadLine();
        }

        private static void FindElement(int[] input, int start, int end)
        {
            
            if (start > end)
                return;
            if (start == end)
            {
                Console.WriteLine("The required element is "
                                                 + input[start]);
                return;
            }
            var mid = (start + end) / 2;

            if (mid % 2 == 0)
            {
                //compare with mid +1
                if(input[mid] == input[mid + 1])
                {
                    FindElement(input, mid + 2, end);
                }
                else
                {
                    FindElement(input, start, mid);
                }
            }
            else
            {
                //compare with mid - 1
                if (input[mid] == input[mid - 1])
                {
                    FindElement(input, mid + 1, end);
                }
                else
                {
                    FindElement(input, start, mid-1);
                }

            }
        }
    }
}
