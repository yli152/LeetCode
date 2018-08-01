using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class TwoSumSolution
    {
        //Dictionary
        public int[] TwoSum(int[] nums, int target) {
            Dictionary<int, int> dc = new Dictionary<int, int>();
            int len = nums.Length;
            int[] result = new int[2];

            for (int i = 0; i < len; i++)
            {
                if (dc.Keys.Contains(target - nums[i]))
                {
                    result[0] = i;
                    result[1] = dc[target - nums[i]];
                    return result;
                }
                else
                {
                    dc[nums[i]] = i;
                }
            }

            return result;
        }
    }
}
