using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class FirstUniqueCharacterInAStringSolution
    {
        //Dictionary
        public int FirstUniqChar(string s) {
            int len = s.Length;
            Dictionary<char, int> dc = new Dictionary<char, int>();

            for (int i = 0; i < len; i++) {
                if (dc.Keys.Contains(s[i]))
                {
                    dc[s[i]]++;
                }
                else {
                    dc[s[i]] = 1;
                }
            }

            for (int i = 0; i < len; i++) {
                if (dc[s[i]] == 1) {
                    return i;
                }
            }

            return -1;
        }
    }
}
