using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //1.fill the Dictionary 2. check if contains[key+1]
    public class LongestHarmoniousSubsequenceSolution
    {
        public int FindLHS(int[] nums) {
            int len = nums.Length;
            int res = 0;
            Dictionary<int, int> dc = new Dictionary<int, int>();

            for (int i = 0; i < len; i++) {
                if (dc.Keys.Contains(nums[i])) {
                    dc[nums[i]]++;
                } else {
                    dc[nums[i]] = 1;
                }
            }

            foreach (var pair in dc) {
                if (dc.Keys.Contains(pair.Key + 1)) {
                    res = Math.Max(res, dc[pair.Key] + dc[pair.Key + 1]);
                }
            }

            return res;
        }
    }
}
