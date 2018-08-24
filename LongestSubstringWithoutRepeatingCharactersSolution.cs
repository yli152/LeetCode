using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LongestSubstringWithoutRepeatingCharactersSolution
    {
        //sliding window
        public int LengthOfLongestSubstring(string s) {
            int len = s.Length;
            HashSet<char> hs = new HashSet<char>();
            int max = 0;
            int i = 0;
            int j = 0;

            while (i < len && j < len) {
                if (!hs.Contains(s[j]))
                {
                    hs.Add(s[j++]);
                    max = Math.Max(max, j - i);
                }
                else {
                    hs.Remove(s[i++]);
                }
            }

            return max;
        }
    }
}
