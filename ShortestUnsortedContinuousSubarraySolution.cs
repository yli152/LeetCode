using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ShortestUnsortedContinuousSubarraySolution
    {
        //Copy and sort a new array, two pointer comparing two arrays 
        public int FindUnsortedSubarray(int[] nums) {
            int len = nums.Length;
            int[] sortedArr = new int[len];
            Array.Copy(nums, 0, sortedArr, 0, len);
            Array.Sort(sortedArr);
            int left = 0;
            int right = nums.Length - 1;

            while (left < right && nums[left] == sortedArr[left])
            {
                left++;
            }

            while (left < right && nums[right] == sortedArr[right])
            {
                right--;
            }

            if (right == left)
            {
                return 0;
            }

            return right - left + 1;
        }
    }
}
