using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //Binary Search check if numbers[left] + numbers[right] == target => left++/right-- 
    public class TwoSumIIInputArrayIsSortedSolution
    {
        public int[] TwoSum(int[] numbers, int target) {
            int len = numbers.Length;
            int[] result = new int[2];
            int left = 0;
            int right = len - 1;

            while (left < right) {
                int sum = numbers[left] + numbers[right];
                if (sum == target)
                {
                    result[0] = left + 1;
                    result[1] = right + 1;
                    return result;
                }
                else if (sum < target)
                {
                    left++;
                }
                else {
                    right--;
                }
            }

            return result;
        }
    }
}
