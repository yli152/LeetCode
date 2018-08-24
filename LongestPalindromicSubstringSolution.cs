using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //extended
    public class LongestPalindromicSubstringSolution
    {
        public string LongestPalindrome(string s)
        {
            int len = s.Length;
            if (s == null || len < 1)
            {
                return "";
            }

            int start = 0;
            int end = 0;
            int max = 0;

            for (int i = 0; i < len; i++)
            {
                int len1 = IsPalindromeAndLength(s, i, i);
                int len2 = IsPalindromeAndLength(s, i, i + 1);
                max = Math.Max(len1, len2);
                if (max > end - start)
                {
                    start = i - (max - 1) / 2;
                    end = i + max / 2;
                }
            }

            return s.Substring(start, max);
        }

        public int IsPalindromeAndLength(string s, int i, int j)
        {
            int len = s.Length;
            while (i >= 0 && j <= len - 1 && s[i] == s[j])
            {
                i--;
                j++;
            }

            return j - i - 1;
        }
    }
}
