using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.StackAndQueue
{
    class NextGreaterElement
    {
        public static void Main()
        {
            Console.WriteLine("Given an array A of size N having distinct elements, " +
                                "the task is to find the next greater element for each element of the array " +
                                "in order of their appearance in the array. If no such element exists, output -1");

            var input = new int[] { 4, 5, 2, 25 };
            int[] output = new int[input.Length];

            Console.WriteLine($"input is {input}");

            Stack<int> s = new Stack<int>();

            s.Push(input[input.Length - 1]);

            for (int i = input.Length-2; i >=0; i--)
            {
                int popped;
                do
                {
                    popped = s.Pop();
                    if (popped == -1)
                    {
                        output[i] = popped;
                        s.Push(input[i]);
                        Console.WriteLine($"output is {popped}");
                        break;
                    }
                    else
                    {
                        if(popped > input[i])
                        {
                            output[i] = popped;
                            s.Push(popped);
                            s.Push(input[i]);
                            Console.WriteLine($"output is {popped}");
                            break;
                        }
                    }
                } while (popped > -1);    
            }

            Console.WriteLine($"output is {output}");

            Console.ReadLine();
        }
    }
}
