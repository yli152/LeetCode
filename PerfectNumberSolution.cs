using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PerfectNumberSolution
    {
        public bool CheckPerfectNumber(int num) {
            //int result = 0;

            //for (int i = 1; i < Math.Sqrt(num); i++) {
            //    if (num % i == 0) {
            //        result += i;
            //    }
            //}

            //return result == num;
            return num == 6 || num == 28 || num == 496 || num == 8128 || num == 33550336;
        }
    }
}
