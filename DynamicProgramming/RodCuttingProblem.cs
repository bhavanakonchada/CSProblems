using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace CSProblems.DynamicProgramming
{
    class RodCuttingProblem
    {
        public static void Main()
        {
            Console.WriteLine("****Rod cutting problem****");
            int[] prices = new int[] { 1, 5, 8, 9, 10, 17, 17, 20 };
            int rodSize = 8;

            //we need to maximize the profit, by cutting the rod appropriately

            //create a matrix to store profits for each length
          
            int[,] profits = new int[rodSize+1, rodSize+1];

            // the first row and first column should be 0 as we are trying to cut the rod into a length of '0' and 
            //that would not yield any profit and also is not possible.
            for (int i = 0; i < rodSize+1; i++)
            {
                profits[i, 0] = 0;
                profits[0, i] = 0;
            }

            /*now we need to start at length 1 and go on till length 8
             * At each length allowed ( or possible), we need to find out what is the maximum profit we can make.
             * While filling up the 2 dimensional array:
             * Columns indicate length of rod to cut
             * Rows indicate allowed length unit to cut
             * 
             * So a cell profits[5,2] would mean, we need to cut a rod of length 2 in pieces of 5 :D - not possible
             * 
             * If for a given length, its possible to run the rod 
             */

            // int[] prices = new int[] { 1, 5, 8, 9, 10, 17, 17, 20 };

            for (int cutLength = 1; cutLength < rodSize + 1; cutLength++)
            {
                for (int rodLength = 1; rodLength < rodSize + 1; rodLength++)
                {
                    //first iteration means, if you can a rod into pieces of 1, what would be the profit ?

                    if (cutLength == 1)
                    {
                        profits[cutLength, rodLength] = prices[cutLength - 1] * rodLength;
                        break;
                    }

                    /*for the second iteration, i.e. cutLength = 2 but we start at rodLength = 1
                     * Thats not possible
                     * So, if cutLength > rodLength - just make the cell 0
                     */
                    if (cutLength > rodLength)
                    {
                        profits[cutLength, rodLength] = profits[cutLength-1,rodLength];
                    }
                    else
                    {
                        profits[cutLength, rodLength] = Math.Max(profits[cutLength - 1, rodLength], prices[cutLength - 1] + profits[cutLength, rodLength - cutLength]);
                    }

                    /* for the second iteration, i.e. cutLength = 2 and rodLength = 5
                     * so, allowed possible cut lengths are: 1 and 2
                     * If I cut the rod into pieces of 2 - 2,2,1 - so profits are 5+5+1 = 11
                     * If I cut the rod into 1,1,1,1,1 - profits are 5*1 = 5
                     * 
                     * If cutLength = 2 and rodLength = 3
                     * 
                     * Max (3, (5+1)) = 6
                     * 
                     * diff = rodLength - cutLength
                     * 1 = 3-2
                     * 
                     * 
                     * Max(profits[cutLength -1, rodLength)  , prices[cutLength -1] + profits[cutLength, rodLength - cutLength -1)   
                     */
                }
                Console.WriteLine($"Printing profits for rodLength of {cutLength}");
                PrintMatrix(profits);
            }

           
        }

        private static void PrintMatrix(int[,] profits)
        {
            int rodSize = 8;

            for (int i = 0; i < rodSize+1; i++)
            {
                for (int j = 0; j < rodSize + 1; j++)
                {
                    Console.Write($"{profits[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
