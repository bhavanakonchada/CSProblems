using CSProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.LinkedList
{
    class ReversingALinkedList
    {
        public static void Main()
        {
            Console.WriteLine(@"Given a singly linked list of N nodes. The task is to reverse the linked list. ");

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

            // trying the most effecient method.
            //avoiding multiple iteration

            var next = head;
            var current = head;
            var prev = head;

            while(current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;                
            }
            head = prev;

            while(head!= null)
            {
                Console.WriteLine($"{head.data}");
            }
            Console.ReadLine();
        }
    }
}
