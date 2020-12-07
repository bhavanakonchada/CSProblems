using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Arrays
{
    class SquaresOfSortedArray
    {
        public static void Main()
        {
            SortedSquares(new int[] { -4, -1, 0, 2, 3 });
        }

            public static int[] SortedSquares(int[] A)
        {
            var output = new int[A.Length];
            //Approach 1: Square each element in the array and then sort the squares.

            //Approach 2:
            //if array contains negative numbers, take their modulus and sort it again


            //Approach 3: 2 pointer approach
            // Example -4 -1 0  2  3
            int left = 0;
            int right = A.Length -1;
            int resultArrayPointer = output.Length - 1;

            for (resultArrayPointer = A.Length - 1; resultArrayPointer > 0; resultArrayPointer--)
            {
                if(Math.Abs(A[left]) > Math.Abs(A[right]))
                {
                    output[resultArrayPointer] = A[left] * A[left];
                    left++;
                }
                else
                {
                    output[resultArrayPointer] = A[right] * A[right];
                    right--;
                }
            }

            ArrayPrinter.Print(output);
            return output;
        }
    }
}
