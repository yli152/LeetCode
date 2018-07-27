using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RemoveDuplicatesFromSortedArraySolution
    {
        //Same with "Remove Element" using nums[index]
        public int RemoveDuplicates(int[] nums) {
            int len = nums.Length;
            if (len == 0) {
                return 0;
            }
            if (len == 1) {
                return 1;
            }

            int index = 1;
            for (int i = 1; i < len; i++) {
                if (nums[i] != nums[i - 1]) {
                    nums[index++] = nums[i];
                }
            }

            return index;
        }
    }
}
