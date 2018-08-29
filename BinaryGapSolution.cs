using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class BinaryGapSolution
    {
        public int BinaryGap(int N) {
            int res = 0;
            for (int d = -32; N > 0; N /= 2, d++)
                if (N % 2 == 1)
                {
                    res = Math.Max(res, d);
                    d = 0;
                }
            return res;
        }
    }
}
