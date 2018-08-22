using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //DP dp[j] - dp[i - 1]
    public class RangeSumQueryImmutableSolution
    {
        int[] dp;
        public RangeSumQueryImmutableSolution(int[] nums) {
            int len = nums.Length;
            for (int i = 1; i < len; i++) {
                nums[i] += nums[i - 1];
            }
            dp = nums;
        }

        public int SumRange(int i, int j) {
            if (i == 0) {
                return dp[j];
            }
            return dp[j] - dp[i - 1];
        }
    }
}
