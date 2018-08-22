using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class HouseRobberSolution
    {
        //DP dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i])
        public int Rob(int[] nums) {
            int len = nums.Length;
            if (len == 0) {
                return 0;
            }
            if (len == 1) {
                return nums[0];
            }
            if (len == 2) {
                return Math.Max(nums[0], nums[1]);
            }

            int[] dp = new int[len];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);
            int result = 0;

            for (int i = 2; i < len; i++) {
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
            }

            return dp[len - 1];
        }
    }
}
