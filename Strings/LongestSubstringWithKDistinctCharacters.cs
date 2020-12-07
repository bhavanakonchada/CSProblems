using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Strings
{
    class LongestSubstringWithKDistinctCharacters
    {
        public static void Main()
        {
            Console.WriteLine("Longest Substring with K Distinct Characters");
            FindLongestString("arraaccii", 3);

            Console.ReadLine();
        }

        public static string FindLongestString(string inputString, int k)
        {
            string output = string.Empty;
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();

            //example input = abbbacc and k = 2; output = abbba
            int windowStart = 0, maxLength = 0;

            for (int windowsEnd = 0; windowsEnd < inputString.Length; windowsEnd++)
            {
                char endChar = inputString[windowsEnd];
                if (charFrequency.ContainsKey(endChar))
                {
                    charFrequency[endChar] = charFrequency[endChar] + 1;
                }
                else
                {
                    charFrequency.Add(endChar, 1);
                }

                while(charFrequency.Count > k)
                {
                    char beginChar = inputString[windowStart];
                    if (charFrequency.ContainsKey(beginChar))
                    {
                        charFrequency[beginChar] = charFrequency[beginChar] - 1;
                    }
                    if(charFrequency[beginChar] == 0)
                    {
                        charFrequency.Remove(beginChar);
                    }
                    windowStart++;
                }

                maxLength = Math.Max(maxLength, (windowsEnd - windowStart + 1));
            }
            //output = maxLength;

            Console.WriteLine($"Max length possible with {k} character is {maxLength}");

            return output;
        }
    }
}
