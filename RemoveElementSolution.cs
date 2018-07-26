using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RemoveElementSolution
    {
        //Like MoveZeros !No need to delete real element, just find the first x elements not val (return that amount --> length)
        public int RemoveElement(int[] nums, int val) {
            int len = nums.Length;
            if (len == 0) {
                return 0;
            }

            int index = 0;
            for (int i = 0; i < len; i++) {
                if (nums[i] != val) {
                    nums[index++] = nums[i];
                }
            }
            return index;
        } 
    }
}
