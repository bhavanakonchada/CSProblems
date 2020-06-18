using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Heap
{    
    class MaxHeap : Heap
    {
        public MaxHeap():base()
        {

        }

        public override bool Compare(int node, int parent)
        {
            return node > parent;
        }
    }
}
