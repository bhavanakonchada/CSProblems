using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSProblems.Trees
{
    class PrintAllKSumPathsInBinaryTree
    {
        static List<int> path = new List<int>();
        public static void Main()
        {
            //create the tree
            Node root = new Node(1);
            root.left = new Node(3);
            root.left.left = new Node(2);
            root.left.right = new Node(1);
            root.left.right.left = new Node(1);
            root.right = new Node(-1);
            root.right.left = new Node(4);
            root.right.left.left = new Node(1);
            root.right.left.right = new Node(2);
            root.right.right = new Node(5);
            root.right.right.right = new Node(2);

            int k = 5;
            printKPath(root, k);
        }

        private static void printKPath(Node root, int k)
        {
            path = new List<int>();
            PrintKPathUtil(root, k);
        }

        private static void PrintKPathUtil(Node root, int k)
        {
            if(root == null)
            {
                return;
            }

            path.Add(root.data);

            PrintKPathUtil(root.left, k);

            PrintKPathUtil(root.right, k);

            //check path
            int f = 0;
            for (int i = path.Count -1; i > 0; i--)
            {
                f += path[i];

                if(k == f)
                {
                    PrintPath(path, i);
                }
            }

            // Remove the current element from the path  
            path.RemoveAt(path.Count - 1);
        }

        static void PrintPath(List<int> list, int start)
        {
            Console.WriteLine("Path is ..");
            for (int i = start; i < list.Count; i++)
            {
                Console.WriteLine($"{list[i]} ");
            }

            Console.WriteLine();
        }
    }

    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }
}
