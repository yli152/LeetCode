using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ValidPerfectSquareSolution
    {
        //Binary Search (mid == num / mid && num % mid == 0)
        public bool IsPerfectSquare(int num) {
            int left = 1;
            int right = num;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (mid == num / mid && num % mid == 0)
                {
                    return true;
                }
                else if (mid > num / mid)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return false;
        }
    }
}
