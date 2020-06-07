using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace CSProblems.Heap
{
    class HeapSort
    {
        public static void Main()
        {
            Console.WriteLine($"Given an array of size N. The task is to sort the array elements by completing " +
                                 $"functions heapify() and buildHeap() which are used to implement Heap Sort.");

            var input = new int[] { 4, 1, 3, 9, 7 };

            MaxHeap heap = new MaxHeap();

            for (int i = 0; i < input.Length; i++)
            {
                heap.Insert(input[i]);
            }

            heap.PrintHeap();

            Console.ReadLine();
        }
    }
}
