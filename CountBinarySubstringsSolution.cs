using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class CountBinarySubstringsSolution
    {
        //prvcount, curcount
        public int countBinarySubstrings(string s) {
            int prvCount = 0, curCount = 0, res = 0, len = s.Length;
            for (int i = 0; i < len; i++)
            {
                curCount++;
                if (i == len - 1 || s[i] != s[i + 1])
                {
                    res += Math.Min(prvCount, curCount);
                    prvCount = curCount;
                    curCount = 0;
                }
            }
            return res;
        }
    }
}
