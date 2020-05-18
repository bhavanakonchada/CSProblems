using CSProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;

namespace CSProblems.Recursion
{
    class NumberOfPathsInAMatrix
    {
        public static void Main()
        {
            Console.WriteLine($"The problem is to count all the possible paths from top left to bottom right of a " +
                              $"MxN matrix with the constraints that from each cell you can either move to right or down.");

           var inputMatrix = new string[3,3]
            {
                { "a","b","c" },{"d","e","f" },{"g","h","i" }
            };

            RecursivePath(inputMatrix, 0, 0, string.Empty);

            Console.ReadLine();
        }

        private static void RecursivePath(string[,] inputMatrix, int row, int col, string result)
        {
           if(row == 2 && col == 2)
            {                
                Console.WriteLine(result + (inputMatrix[row, col]));
                return;
            }

           if(row+1< 3)
            {
                RecursivePath(inputMatrix, row + 1, col, result+(inputMatrix[row,col]));
            }

           if(col+1 < 3)
            {
                RecursivePath(inputMatrix, row, col + 1, result+(inputMatrix[row, col]));
            }
        }
    }
}
