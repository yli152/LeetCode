using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class KdiffPairsInAnArraySolution
    {
        //Dictionary 1. Initiate dictionary with the number of elements in nums 2. Tranverse dictionary (k == 0 / k != 0)
        public int FindPairs(int[] nums, int k) {
            Dictionary<int, int> dc = new Dictionary<int, int>();
            int len = nums.Length;
            int result = 0;

            if (len == 0 || k < 0)
            {
                return 0;
            }

            for (int i = 0; i < len; i++)
            {
                if (dc.Keys.Contains(nums[i]))
                {
                    dc[nums[i]]++;
                }
                else
                {
                    dc[nums[i]] = 1;
                }
            }

            foreach (var key in dc.Keys)
            {
                if (k == 0)
                {
                    if (dc[key] >= 2)
                    {
                        result++;
                    }
                }
                else
                {
                    if (dc.Keys.Contains(key + k))
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
