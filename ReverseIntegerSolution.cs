using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //long.Parse(sb.ToString()) < int.MinValue || long.Parse(sb.ToString()) > int.MaxValue
    public class ReverseIntegerSolution
    {
        public int Reverse(int x) {
            if (x == 0)
            {
                return 0;
            }
            string s = x.ToString();
            int len = s.Length;
            if (len == 1)
            {
                return x;
            }

            StringBuilder sb = new StringBuilder();
            int limit = 0;
            if (x < 0)
            {
                limit = 1;
                sb.Append('-');

            }

            for (int i = len - 1; i >= limit; i--)
            {
                if (s[i] != 0)
                {
                    sb.Append(s[i]);
                }
            }

            if (long.Parse(sb.ToString()) < int.MinValue || long.Parse(sb.ToString()) > int.MaxValue) {
                return 0;
            }
            return (int)long.Parse(sb.ToString());
        }
    }
}
