using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MaximumSubarraySolution
    {
        public int MaxSubArray(int[] nums)
        {
            //DP --> everytime check if dp[i - 1] > 0
            int len = nums.Length;
            int[] dp = new int[len];
            dp[0] = nums[0];
            int max = dp[0];
            for (int i = 1; i < len; i++)
            {
                if (dp[i - 1] > 0)
                {
                    dp[i] = dp[i - 1] + nums[i];
                }
                else
                {
                    dp[i] = nums[i];
                }

                if (dp[i] > max)
                {
                    max = dp[i];
                }
            }

            return max;
        }
    }
}