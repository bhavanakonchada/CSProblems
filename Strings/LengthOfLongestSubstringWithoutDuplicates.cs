using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Strings
{
    class LengthOfLongestSubstringWithoutDuplicates
    {
        //example input : abcabcbb
        /*
         * a-1
         * b-1
         * c-1
         * a-1
         * b-1
         * c-1
         * b-2
         * 
         * 
         */
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            if(s.Length == 0)
            {
                return 0;
            }

            string distinctString = string.Empty;
            int windowStart = 0;
            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {
                var endChar = s[windowEnd];
                if (!distinctString.Contains(endChar))
                {
                    s += endChar;
                }
                if (distinctString.Contains(endChar))
                {
                    //remove
                    //s.
                }

            }

            return 0;
        }
    }
}
