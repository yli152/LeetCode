﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //DP dp[i] = dp[i - 1] + dp[i - 2]
    public class ClimbingStairsSolution
    {
        public int ClimbStairs(int n) {
            if (n <= 1) {
                return 1;
            }
            if (n == 2) {
                return 2;
            }

            int[] dp = new int[n];
            dp[0] = 1;
            dp[1] = 2;
            for (int i = 2; i < n; i++) {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n - 1];
        }
    }
}
