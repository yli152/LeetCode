using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    // 1 and 7  don't loop
    public class HappyNumberSolution
    {
        public bool IsHappy(int n) {
            int hold = 0;
            while (n != 0)
            {
                hold += (int)Math.Pow((n % 10), 2);
                n = n / 10;
            }
            if (hold == 1)
                return true;
            else if (hold < 10 && hold != 7)
                return false;

            return IsHappy(hold);
        }
    }
}
