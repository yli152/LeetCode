using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class FactorialTrailingZeroesSolution
    {
        //count how many fives
        public int TrailingZeroes(int n) {
            int result = 0;

            while (n != 0) {
                result += n / 5;
                n /= 5; 
            }

            return result;
        }
    }
}
