using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //return sum - min * len
    public class MinimumMovesToEqualArrayElementsSolution
    {
        public int MinMoves(int[] nums) {
            int min = Int32.MaxValue;
            int len = nums.Length;
            int sum = 0;

            for (int i = 0; i < len; i++)
            {
                sum += nums[i];
                min = Math.Min(min, nums[i]);
            }
            return sum - min * len;
        }
    }
}
