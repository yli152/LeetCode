using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class FindTheDifferenceSolution
    {
        //Dictionary dc[t[i]]--
        public char FindTheDifference(string s, string t) {
            int lens = s.Length;
            int lent = t.Length;
            Dictionary<char, int> dc = new Dictionary<char, int>();

            for (int i = 0; i < lens; i++) {
                if (dc.Keys.Contains(s[i]))
                {
                    dc[s[i]]++;
                }
                else {
                    dc[s[i]] = 1;
                }
            }

            for (int i = 0; i < lent; i++) {
                if (dc.Keys.Contains(t[i])) {
                    dc[t[i]]--;
                }
            }

            foreach (var pair in dc) {
                if (pair.Value != 0) {
                    return pair.Key;
                }
            }

            return t[lent - 1];
        }
    }
}
