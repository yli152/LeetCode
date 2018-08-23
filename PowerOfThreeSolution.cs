using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    // % /
    public class PowerOfThreeSolution
    {
        public bool IsPowerOfThree(int n) {
            while (n % 3 == 0) {
                n %= 3;
            }

            return n == 0;
        }

        //return (n>0 &&  1162261467%n==0);
    }
}
