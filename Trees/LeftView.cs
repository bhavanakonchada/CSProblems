using CSProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Trees
{
    class LeftView
    {
        public static void Main()
        {
            Console.WriteLine("Given a Binary Tree, print Left view of it. Left view of a Binary Tree is set of nodes" +
                " visible when tree is visited from Left side. The task is to complete the function leftView(), " +
                "which accepts root of the tree as argument.");


            BSTNode<int> root = new BSTNode<int>(1);
            BSTNode<int> node2 = new BSTNode<int>(2);
            BSTNode<int> node3 = new BSTNode<int>(3); 
            BSTNode<int> node4 = new BSTNode<int>(4); 
            BSTNode<int> node5 = new BSTNode<int>(5);
            BSTNode<int> node6 = new BSTNode<int>(6); 
            BSTNode<int> node7 = new BSTNode<int>(7);
            BSTNode<int> node8 = new BSTNode<int>(8);

            root.left = node2;
            root.right = node3;
            node2.left = node4;
            node2.right = node5;
            node3.left = node6;
            node3.right = node7;
            node4.left = node8;

            //left view

            var current = root;

            while(current!= null)
            {
                Console.WriteLine($"{current.data}");
                current = current.left;
            }

            Console.ReadLine();
        }
    }
}
