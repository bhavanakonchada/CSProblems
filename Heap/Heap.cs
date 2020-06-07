using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Heap
{
    public abstract class Heap
    {
        int[] Elements;
        int HeapSize;

        int MAX_HEAP_SIZE = 20;

        public Heap()
        {
            Elements = new int[MAX_HEAP_SIZE];
        }

        public abstract bool Compare(int one, int two);

        public int Left(int i)
        {
            return Elements[2 * i + 1];
        }

        public int Right(int i)
        {
            return Elements[2 * (i + 1)];
        }

        public void Swap(int one, int two)
        {
            int temp = one;
            one = two;
            two = temp;
        }

        public int Parent(int i)
        {
            if (i == 0)
            {
                return -1;
            }
            else
            {
                return (i - 1) / 2;
            }
        }

        public int Top()
        {
            return Elements[0];
        }

        public int Count()
        {
            return HeapSize + 1;
        }

        public void Heapify(int i)
        {
            int p = Parent(i);
            if (p >= 0 && Compare(Elements[i], Elements[p]))
            {
                //swap elements
                var temp = Elements[i];
                Elements[i] = Elements[p];
                Elements[p] = temp;

                Heapify(p);
            }
        }

        public int DeleteTop()
        {
            int itemToDelete = -1;
            if (HeapSize > -1)
            {
                itemToDelete = Elements[0];
                Swap(Elements[0], Elements[HeapSize]);
                HeapSize--;
                Heapify(Parent(HeapSize));
            }

            return itemToDelete;
        }

        public bool Insert(int newItem)
        {
            bool result = false;
            if (HeapSize < MAX_HEAP_SIZE)
            {
                result = true;
                Elements[HeapSize] = newItem;
                Heapify(HeapSize);
                HeapSize++;
            }
            return result;
        }

        public void PrintHeap()
        {
            for (int i = 0; i < HeapSize; i++)
            {
                Console.WriteLine($"{Elements[i]} ");
            }
        }
    }
}
