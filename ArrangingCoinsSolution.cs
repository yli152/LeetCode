using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ArrangingCoinsSolution
    {
        public int ArrangeCoins(int n) {
            int num = n;
            int result = 0;

            for (int i = 1; n - i >= 0; i++) {
                n -= i;
                result++;
            }

            return result;
        }
    }
}
