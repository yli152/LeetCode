using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class SearchInsertPositionSolution
    {
        public int SearchInsert(int[] nums, int target) {
            //Solution 1:
            /*
            int len = nums.Length;

            if (len == 0)
            {
                return 0;
            }

            if (len == 1)
            {
                if (target <= nums[0])
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

            for (int i = 0; i <= len - 2; i++)
            {
                if (target <= nums[i])
                {
                    return i;
                }
                else if (target <= nums[i + 1])
                {
                    return i + 1;
                }
            }

            return len;*/

            //solution 2:
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right) {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else {
                    left = mid + 1;
                }
            }
            return left;
        }
    }
}
