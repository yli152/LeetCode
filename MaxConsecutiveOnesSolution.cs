using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MaxConsecutiveOnesSolution
    {
        //count, max
        public int FindMaxConsecutiveOnes(int[] nums) {
            int len = nums.Length;
            int count = 0;
            int max = 0;

            if (len == 0)
            {
                return 0;
            }

            if (nums[0] == 1)
            {
                count++;
                max++;
            }

            for (int i = 1; i < len; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count > max)
                {
                    max = count;
                }
            }

            return max;
        }
    }
}
