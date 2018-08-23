using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //Look for the critical point: i* i <= x && (i+1)(i+1) > x
    public class SqrtXSolution
    {
        public int MySqrt(int x) {
            if (x == 0 || x == 1)
            {
                return x;
            }

            for (int i = 1; i <= x / i; i++)
            {
                if (i <= x / i && (i + 1) > x / (i + 1))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

//public int mySqrt(int x)
//{
//    if (x == 0) return 0;
//    for (int i = 1; i <= x / i; i++)
//        if (i <= x / i && (i + 1) > x / (i + 1))// Look for the critical point: i*i <= x && (i+1)(i+1) > x
//            return i;
//    return -1;
//}