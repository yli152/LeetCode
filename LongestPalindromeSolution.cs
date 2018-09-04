using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //HashSet minus odds and plus one / hs.Add and hs.Remove
    public class LongestPalindromeSolution
    {
        public int LongestPalindrome(string s) {
            int lens = s.Length;
            HashSet<char> hs = new HashSet<char>();

            for (int i = 0; i < lens; i++) {
                if (!hs.Contains(s[i])) {
                    hs.Add(s[i]);
                } else {
                    hs.Remove(s[i]);
                }
            }

            int lenhs = hs.Count;

            return lenhs <= 1 ? lens : lens - lenhs + 1;
        }
    }
}
