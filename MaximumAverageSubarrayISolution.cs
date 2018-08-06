using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MaximumAverageSubarrayISolution
    {
        //slide window
        public double FindMaxAverage(int[] nums, int k) {
            int len = nums.Length;

            if (len < k) {
                return 0;
            }
            int max = 0;

            for (int i = 0; i < k; i++) {
                max += nums[i];
            }

            int sum = max;

            for (int i = 1; i < len - k + 1; i++) {
                sum = sum - nums[i - 1] + nums[i + k - 1];

                if (sum > max) {
                    max = sum;
                }
            }

            return max;
        }
    }
}
