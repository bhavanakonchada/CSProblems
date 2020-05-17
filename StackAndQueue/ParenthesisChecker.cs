using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.StackAndQueue
{
    class ParenthesisChecker
    {
        public static void Main()
        {
            Console.WriteLine(@"Given an expression string exp. " +
                              "Examine whether the pairs and the orders of “{“,”}”,”(“,”)”,”[“,”]” are correct in exp.");

            List<char> openVariants = new List<char>() { '{', '(', '[' };
            List<char> closeVariants = new List<char>() { '}', ')', ']' };

            var input = "{([])}{";
            Console.WriteLine($"Input is {input}");
            //Stack approach
            Stack<char> s = new Stack<char>();

            foreach (var item in input)
            {
                if (openVariants.Contains(item))
                {
                    s.Push(item);
                }
                else if (closeVariants.Contains(item))
                {
                   var poppedItem = s.Pop();
                    Console.WriteLine($"Found pair: {item}, {poppedItem}");
                }
                else
                {
                    // no action
                }
            }

            if(s.Count == 0)
            {
                Console.WriteLine("Input is balanced");
            }
            else
            {
                Console.WriteLine("Input is un-balanced");
            }
            Console.ReadLine();
        }
    }
}
