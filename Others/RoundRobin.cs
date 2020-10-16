using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Others
{
    class RoundRobin
    {
        public static void Main()
        {
            var teamMembers = new string[] { "anvi", "asmi", "sree" };
            int eachCount = 2;

            var rotationArray = new string[teamMembers.Length * eachCount];

            int rIndex = 0;
            //construct the rotationarray
            foreach (var name in teamMembers)
            {
                for (int i = 0; i < eachCount; i++)
                {
                    rotationArray[rIndex] = name;
                    rIndex++;
                }
            }

            PrintArray(rotationArray);

            //Input a number of assignments
            //  Console.WriteLine("Enter the number of assignments to make:");
            int noOfAssignments = 7;

            Console.WriteLine("Enter previous assignees ( comma seperated list of names):");
            string assignedList = Console.ReadLine();

            //parse the previous assignment to know where to begin from
            var assigned = assignedList.Split(',');

            //get the index from where the new assignment gotta begin
            int beginIndex = MatchArray(rotationArray, assigned);

            Console.WriteLine("Printing assignments..");
            //start assigning from the 'beginIndex'
            for (int i = 0; i < noOfAssignments; i++)
            {
                if (beginIndex == rotationArray.Length)
                {
                    beginIndex = 0;
                }

                Console.WriteLine(rotationArray[beginIndex]);
                beginIndex++;
               
            }

            Console.ReadLine();
        }

        //the assumption is :assigned array has elements in the same order as rotation array and has length less that rotation array
        private static int MatchArray(string[] rotationArray, string[] assigned)
        {
            //make 2 copies of the rotation array

            var rotationArrayLong = new string[rotationArray.Length * 2];
            Array.Copy(rotationArray, rotationArrayLong, rotationArray.Length);
            Array.Copy(rotationArray, 0, rotationArrayLong, rotationArray.Length, rotationArray.Length);

            int i = 0, j = 0;
            int n = rotationArray.Length;
            int m = assigned.Length;


            while (i < n && j < m)
            {
                if (rotationArray[i] == assigned[j])
                {
                    i++;
                    j++;
                    if (j == m)
                    {
                        //we have completed the traversal
                        break;
                    }
                }

                else
                {
                    i = i - j + 1;
                    j = 0;
                }
            }

            return i;
        }

        private static void PrintArray(string[] profits)
        {
            for (int j = 0; j < profits.Length; j++)
            {
                Console.Write($"{profits[j]} ");
            }
            Console.WriteLine();
        }
    }
}
