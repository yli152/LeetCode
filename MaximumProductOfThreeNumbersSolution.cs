using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MaximumProductOfThreeNumbersSolution
    {
        //!!!Tricky Math: first sort array, then compare 最大三个积和第一个与最小两个的积
        public int MaximumProduct(int[] nums) {
            int len = nums.Length;
            Array.Sort(nums);
            return Math.Max(nums[0] * nums[1] * nums[len - 1], nums[len - 3] * nums[len - 2] * nums[len - 1]);
        }
    }
}
