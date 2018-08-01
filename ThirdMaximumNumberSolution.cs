using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ThirdMaximumNumberSolution
    {
        // using Long.MinValue instead of Int32.MinValue
        public int ThirdMax(int[] nums) {
            long max = long.MinValue;
            long second = long.MinValue;
            long third = long.MinValue;
            long len = nums.Length;

            for (int i = 0; i < len; i++)
            {
                if (nums[i] == max || nums[i] == second || nums[i] == third)
                {
                    continue;
                }

                if (nums[i] > max)
                {
                    third = second;
                    second = max;
                    max = nums[i];
                }
                else if (nums[i] > second)
                {
                    third = second;
                    second = nums[i];
                }
                else if (nums[i] > third)
                {
                    third = nums[i];
                }
            }

            if (third == long.MinValue || third == second) {
                return (int)max;
            }
            return (int)third;
        }
    }
}
