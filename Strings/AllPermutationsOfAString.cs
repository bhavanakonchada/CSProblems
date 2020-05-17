using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CSProblems.Strings
{
    class AllPermutationsOfAString
    {
        public static void Main()
        {
            Console.WriteLine(@"Given a string S. The task is to print all permutations of a given string.");

            string input = "ABC";
            Console.WriteLine($"Input is {input}");

            char[] inputParsed = input.ToCharArray();

            var result = Permutations("", "ABC");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        private static List<string> Permutations(string baseString, string suffixString )
        {
            if (suffixString.Length == 1)
            
            {
                var printList = new List<string>();
                printList.Add(suffixString);
                return Merge(baseString, printList);
            }

            else
            {
                var newBase = suffixString.ElementAt(0);
                var newSuffix = suffixString.Substring(1);
                return Merge(baseString, Permutations(newBase.ToString(), newSuffix));
            }
        }

        private static List<string> Merge(string baseString, List<string> suffixList)
        {
            List<string> result = new List<string>();
            if (string.IsNullOrEmpty(baseString))
            {
                result = suffixList;
            }
            else
            {
                foreach (var item in suffixList)
                {
                    result.Add(baseString + item);
                    result.Add(item + baseString);
                }
            }

            return result;
        }
    }
}
