using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Heap
{
    public abstract class Heap<T>
    {
        T[] Elements;
        int HeapSize;

        int MAX_HEAP_SIZE = 100;

        public abstract bool Compare(T one, T two);

        T Left(int i)
        {
            return Elements[2 * i + 1];
        }

        T Right(int i)
        {
            return Elements[2 * (i + 1)];
        }

        void Swap(T one, T two)
        {
            T temp = one;
            one = two;
            two = temp;
        }

        int Parent(int i)
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

        T Top()
        {
            return Elements[0];
        }

        int Count()
        {
            return HeapSize + 1;
        }

        void Heapify(int i)
        {
            int p = Parent(i);
            if (p >= 0 && Compare(Elements[i], Elements[p]))
            {
                Swap(Elements[i], Elements[p]);
                Heapify(p);
            }
        }

        T DeleteTop()
        {
            T itemToDelete = default(T);
            if (HeapSize > -1)
            {
                itemToDelete = Elements[0];
                Swap(Elements[0], Elements[HeapSize]);
                HeapSize--;
                Heapify(Parent(HeapSize));
            }

            return itemToDelete;
        }

        bool Insert(T newItem)
        {
            bool result = false;
            if (HeapSize < MAX_HEAP_SIZE)
            {
                result = true;
                HeapSize++;
                Elements[HeapSize] = newItem;
                Heapify(HeapSize);
            }
            return result;
        }
    }
}
