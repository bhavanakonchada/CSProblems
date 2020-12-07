using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Arrays.Sorting
{
    class InsertionSort
    {
        public static void Main()
        {
            var input = new int[] { 8, 2, 4, 9, 3, 6 };
            Insertion_Sort(input);
        }
       public static void Insertion_Sort(int[] input)
        {
            var n = input.Length;
            for (int i = 1; i < n; i++)
            {
                int key = input[i];
                int j = i - 1;
                //while(j >= 0 && input[j] > key)
                //{
                //    //swap them
                //    var temp = input[j];
                //    input[j] = input[i];
                //    input[i] = temp;

                //   // key = input[j];
                //    j--;
                //}


                while (j >= 0 && input[j] > key)
                {
                    input[j + 1] = input[j];
                    j = j - 1;
                }
                input[j + 1] = key;


                PrintArray(input);
            }

            Console.ReadLine();
        }


        public static int[] InsertionSortByShift(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int j;
                var insertionValue = inputArray[i];
                for (j = i; j > 0; j--)
                {
                    if (inputArray[j - 1] > insertionValue)
                    {
                        inputArray[j] = inputArray[j - 1];
                    }
                }
                inputArray[j] = insertionValue;

                PrintArray(inputArray);
            }


            return inputArray;
        }

        public static void PrintArray(int[] input)
        {
            for (int k = 0; k < input.Length; k++)
            {
                Console.Write(input[k] + " ");
            }
            Console.WriteLine();
        }
    }
}

/*
 * Sample input: 8 2 4 9 3 6
 * 
 * 8 2 4 9 3 6
 * 2 8 4 9 3 6
 * 2 4 8 9 3 6
 *          2 4 8 3 9 6
 *          2 4 3 8 9 6
 *          2 3 4 8 9 6
 * 2 3 4 8 9 6
 *         2 3 4 8 6 9
 *         2 3 4 6 8 9
 */
