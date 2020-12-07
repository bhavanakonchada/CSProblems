using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Strings
{
    public class RegularExpressionMatching
    {
        /* Given an input string (s) and a pattern (p), implement regular expression matching with support for '.' and '*' where: 

            '.' Matches any single character.​​​​
            '*' Matches zero or more of the preceding element.
            The matching should cover the entire input string (not partial).

            Example 1:

            Input: s = "aa", p = "a"
            Output: false
            Explanation: "a" does not match the entire string "aa".
            Example 2:

            Input: s = "aa", p = "a*"
            Output: true
            Explanation: '*' means zero or more of the preceding element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".
            Example 3:

            Input: s = "ab", p = ".*"
            Output: true
            Explanation: ".*" means "zero or more (*) of any character (.)".
            Example 4:

            Input: s = "aab", p = "c*a*b"
            Output: true
            Explanation: c can be repeated 0 times, a can be repeated 1 time. Therefore, it matches "aab".
            Example 5:

            Input: s = "mississippi", p = "mis*is*p*."
            Output: false
 

            Constraints:

            0 <= s.length <= 20
            0 <= p.length <= 30
            s contains only lowercase English letters.
            p contains only lowercase English letters, '.', and '*'.
          */

        public static void Main()
        {
            string masterstring = "bhavana";
            string pattern = "bha.";

            // we need to use string operations

            Console.ReadLine();
        }

        bool PatternMatcher(string masterString, string pattern)
        {
            if (string.IsNullOrEmpty(masterString))
            {
                return false;
            }

            if (string.IsNullOrEmpty(pattern))
            {
                return false;
            }
            return false;
        }
    }
}
