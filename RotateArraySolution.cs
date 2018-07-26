using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //Reverse() Three Times
    public class RotateArraySolution
    {
        public void Rotate(int[] nums, int k) {
            //Time Limited:
            //-----------------------------------------
            //int len = nums.Length;
            //int number = 0;
            //for (int i = 0; i < k; i++) {
            //    number = nums[len - 1];
            //    for (int j = len - 1; j > 0; j--) {
            //        nums[j] = nums[j - 1];
            //    }
            //    nums[0] = number;
            //}
            //Solution:
            //-------------------------------------------
            int len = nums.Length;
            k %= len;
            Reverse(nums, 0, len - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, len - 1);
        }

        public void Reverse(int[] nums, int start, int end) {
            while (start < end) {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
