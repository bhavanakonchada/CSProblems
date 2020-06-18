using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.DynamicProgramming
{
    class MinimumOperations
    {
        public static void Main()
        {
            Console.WriteLine($"You are given a number N. You have to find the number of operations required to reach N from 0. " +
                $"You have 2 operations available: * Double the number * Add one to the number");

            var N = 7;
            int current = N;
            var stepCount = 0;
            while(current > 0)
            {
                if(current % 2 == 0)
                {
                    stepCount++;
                    current = current / 2;
                }
                else
                {
                    current--;
                    stepCount++;
                }
            }

            Console.WriteLine($"Number of steps needed to make {N} from 0 is {stepCount}");

            Console.ReadLine();
        }
    }
}
