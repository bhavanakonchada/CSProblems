using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Models
{
    class BSTNode<T>
    {
        public BSTNode(T value)
        {
            data = value;
        }
        public T data;
        public BSTNode<T> left;
        public BSTNode<T> right;
    }
}
