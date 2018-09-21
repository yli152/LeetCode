using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //Dictionary 2O(N)
    public class NextGreaterElementISolution
    {
        public int[] NextGreaterElement(int[] findNums, int[] nums) {
            int lend = findNums.Length;
            int lenp = nums.Length;
            Dictionary<int, int> dc = new Dictionary<int, int>();

            for (int i = 0; i < lenp; i++) {
                if (!dc.Keys.Contains(nums[i])) {
                    dc[nums[i]] = i;
                }
            }

            for (int i = 0; i < lend; i++) {
                int j = dc[findNums[i]];
                while (j < lenp && findNums[i] >= nums[j]) {
                    j++;
                }
                if (j >= lenp)
                {
                    findNums[i] = -1;
                }
                else {
                    findNums[i] = nums[j];
                }
            }

            return findNums;
        }
    }
}
