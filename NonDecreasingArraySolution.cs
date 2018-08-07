using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class NonDecreasingArraySolution
    {
        //check two situations:前一位大于后一位，后一位加一 1.前一位在后一位基础上减一 2.后一位在前一位基础上加一
        public bool CheckPossibility(int[] nums) {
            int len = nums.Length;
            int countOriginal = 0;
            int countCopy = 0;
            int[] copy = new int[len];
            Array.Copy(nums, copy, len);

            for (int i = 0; i < len - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    nums[i + 1] = nums[i] + 1;
                    countOriginal++;
                }

                if (copy[i] > copy[i + 1])
                {
                    copy[i] = copy[i + 1] - 1;
                    countCopy++;
                    if (i - 1 >= 0 && copy[i - 1] > copy[i])
                    {
                        copy[i - 1] = copy[i] - 1;
                        countCopy++;
                    }
                }
            }

            return (countOriginal <= 1 || countCopy <= 1) ? true : false;
        }
    }
}
