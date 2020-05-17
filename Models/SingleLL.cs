using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Models
{
    class SingleLLNode<T>
    {
        public SingleLLNode(T value)
        {
            data = value;
            next = null;
        }
        public T data;
        public SingleLLNode<T> next;
    }
}
