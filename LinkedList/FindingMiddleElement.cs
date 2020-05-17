using CSProblems.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CSProblems.LinkedList
{
    class FindingMiddleElement
    {
        public static void Main()
        {
            Console.WriteLine(@"Given a singly linked list of N nodes. 
                    The task is to find middle of the linked list. 
                    For example, if given linked list is 1->2->3->4->5 then output should be 3.");

            SingleLLNode<int> head = new SingleLLNode<int>(1);
            SingleLLNode<int> node2 = new SingleLLNode<int>(2);
            SingleLLNode<int> node3 = new SingleLLNode<int>(3);
            SingleLLNode<int> node4 = new SingleLLNode<int>(4); 
            SingleLLNode<int> node5 = new SingleLLNode<int>(5);
            SingleLLNode<int> node6 = new SingleLLNode<int>(6);
            SingleLLNode<int> node7 = new SingleLLNode<int>(7);

            head.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node5.next = node6;
            node6.next = node7;

            //begin detection of middle node

            var midNode = head;
            var pointerNode = head;
            int count = 0;

            while(pointerNode != null)
            {
                pointerNode = pointerNode.next;                

                if(count % 2 == 1) // if odd
                {
                    midNode = midNode.next;
                }
                count++;
            }

            Console.WriteLine($"Middle element is {midNode.data}");

            Console.ReadLine();
        }
    }
}
