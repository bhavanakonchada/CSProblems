using CSProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Trees
{
    class CheckIfBinaryTreeIsBST
    {
        public static void Main()
        {
            Console.WriteLine(@"Given a binary tree, return true if it is BST, else false. 
                        For example, the following tree is not BST, because 11 is in the left subtree of 10. 
                        The task is to complete the function isBST() which takes one argument, root of Binary Tree.");


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

            //Check If Binary Tree

            var current = root;

            bool result = isBST(root, root.left, root.right);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static bool isBST(BSTNode<int> root, BSTNode<int> left, BSTNode<int> right)
        {
            if(root == null)
            {
                return true;
            }

            if(left != null && left.data > root.data)
            {
                return false;
            }

            if (right!=null && right.data < root.data)
            {
                return false;
            }

            return (isBST(left, left.left, left.right) && isBST(right, right.left, right.right));
        }
    }
}
