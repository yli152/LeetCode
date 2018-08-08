using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //2O(N) sumr等于总和，然后遍历sumr减一个和suml比较，没有的话suml再加上这个
    public class FindPivotIndexSolution
    {
        public int PivotIndex(int[] nums) {
            //int left = 0;
            //int right = nums.Length - 1;
            //int suml = nums[left];
            //int sumr = nums[right];
            //int pivot = -1;

            //while (left < right) {
            //    if (suml < sumr) {
            //        left++;
            //        suml += nums[left];
            //    }
            //    if (sumr < suml) {
            //        right--;
            //        sumr += nums[right];
            //    }
            //    if (suml == sumr) {
            //        if (right - left == 2) {
            //            pivot = left + 1;
            //            return pivot;
            //        }
            //    }
            //}

            //return pivot;

            int len = nums.Length;
            int sumr = 0;
            int suml = 0;
            if (len == 0) {
                return -1;
            }

            for (int i = 0; i < len; i++) {
                sumr += nums[i];
            }

            for (int i = 0; i < len; i++) {
                sumr -= nums[i];
                
                if (sumr == suml) {
                    return i;
                }

                suml += nums[i];
            }

            return -1;
        }
    }
}
