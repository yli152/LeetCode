using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MissingNumberSolution
    {
        //sum - actualsum
        public int MissingNumber(int[] nums) {
            int len = nums.Length;
            int sum = (1 + len) * len / 2;

            int actualSum = 0;
            for (int i = 0; i <len; i++) {
                actualSum += nums[i];
            }

            return sum - actualSum;
        }
    }
}
