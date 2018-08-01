using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ContainsDuplicateIISolution
    {
        //Dictionary
        public bool ContainsNearbyDuplicate(int[] nums, int k) {
            Dictionary<int, int> dc = new Dictionary<int, int>();
            int len = nums.Length;
            bool flag = false;

            for (int i = 0; i < len; i++) {
                if (dc.Keys.Contains(nums[i])) {
                    if (i - dc[nums[i]] <= k) {
                        flag = true;
                    }
                    dc[nums[i]] = i;
                } else {
                    dc[nums[i]] = i;
                }
            }

            return flag;
        }
    }
}
