using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ContainsDuplicateSolution
    {
        //Dictionary
        public bool ContainsDuplicate(int[] nums) {
            Dictionary<int, int> dc = new Dictionary<int, int>();
            int len = nums.Length;

            for (int i = 0; i < len; i++) {
                if (dc.Keys.Contains(nums[i]))
                {
                    return true;
                }
                else {
                    dc[nums[i]] = 1;
                }
            }

            return false;
        }
    }
}
