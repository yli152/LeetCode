using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RangeAdditionIISolution
    {
        public int MaxCount(int m, int n, int[,] ops) {
            int x = m;
            int y = n;
            int len = ops.Length;
            for (int i = 0; i < len; i++)
            {
                if (ops[i,0] <= x)
                {
                    x = ops[i, 0];
                }
                if (ops[i,1] <= y)
                {
                    y = ops[i, 1];
                }
            }
            return x * y;
        }
    }
}
