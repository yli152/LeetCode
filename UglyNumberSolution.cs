using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //分情况除2,3,5
    public class UglyNumberSolution
    {
        public bool IsUgly(int num) {
            if (num == 0) {
                return false;
            }

            while (num % 2 == 0) {
                num /= 2;
            }

            while (num % 3 == 0)
            {
                num /= 3;
            }

            while (num % 5 == 0)
            {
                num /= 5;
            }

            return num == 1;
        }
    }
}
