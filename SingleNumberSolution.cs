using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class SingleNumberSolution
    {
        public int SingleNumber(int[] nums) {
            int len = nums.Length;
            Dictionary<int, int> dc = new Dictionary<int, int>();

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

            foreach (var pair in dc)
            {
                if (pair.Value == 1)
                {
                    return pair.Key;
                }
            }

            return 0;
        }
    }
}
