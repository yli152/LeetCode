using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ArrayPartitionISolution
    {
        //Sorting first and then add all elements in odd index
        public int ArrayPairSum(int[] nums) {
            Array.Sort(nums);
            int len = nums.Length;
            int result = 0;

            for (int i = 0; i < len; i += 2) {
                result += nums[i];
            }

            return result;
        }
    }
}
