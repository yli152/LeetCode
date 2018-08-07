using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LongestContinuousIncreasingSubsequenceSolution
    {
        public int FindLengthOfLCIS(int[] nums) {
            int len = nums.Length;
            if (len == 0)
            {
                return 0;
            }

            int result = 1;
            int count = 1;

            for (int i = 0; i < len - 1; i++)
            {
                if (nums[i + 1] > nums[i])
                {
                    count++;
                }
                else
                {
                    if (count > result)
                    {
                        result = count;
                    }
                    count = 1;
                }
            }

            if (count > result)
            {
                result = count;
            }

            return result;
        }
    }
}
