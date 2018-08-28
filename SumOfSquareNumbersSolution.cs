using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class SumOfSquareNumbersSolution
    {
        public bool JudgeSquareSum(int c) {
            int limit = (int)Math.Sqrt(c);

            for (int i = 0; i <= limit; i++) {
                int temp = i * i;
                int res = (int)Math.Sqrt(c - temp);
                if ((res * res + temp) == c) {
                    return true;
                }
            }

            return false;
        }
    }
}
