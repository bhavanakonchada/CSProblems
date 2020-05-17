using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSProblems.Strings
{
    class ReverseWordsInAString
    {
        public static void Main()
        {
            Console.WriteLine(@"Given a String of length S, reverse the whole string without reversing the individual words in it.
                        Words are separated by dots.");

            string input = "anvi.and.mummy.are.friends";
            Console.WriteLine($"Input is {input}");

            string[] inputParsed = input.Split('.');
            Array.Reverse(inputParsed);

            StringBuilder sb = new StringBuilder();
            foreach (var item in inputParsed)
            {
                sb.Append( item + '.');
            }
            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine($"Input with reversed words is : {sb}");

        }
    }
}
