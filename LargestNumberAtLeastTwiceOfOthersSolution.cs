using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LargestNumberAtLeastTwiceOfOthersSolution
    {
        //2O(N)
        public int DominationIndex(int[] nums) {
            int len = nums.Length;
            int max = Int32.MinValue;
            int result = 0;

            for (int i = 0; i < len; i++) {
                if (nums[i] > max) {
                    max = nums[i];
                    result = i;
                }
            }

            for (int i = 0; i < len; i++) {
                if (nums[i] != max)
                {
                    if (2 * nums[i] > max)
                    {
                        result = -1;
                    }
                }
            }

            return result;
        }
    }
}
