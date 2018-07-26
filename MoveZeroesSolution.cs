using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MoveZeroesSolution
    {
        //Traverse Twice. First: assign all non 0 values to the left. Second: fill the remains with 0
        public void MoveZeroes(int[] nums)
        {
            int len = nums.Length;

            if (nums.Length == 0)
            {
                return;
            }

            int index = 0;
            for (int i = 0; i < len; i++) {
                if (nums[i] != 0) {
                    nums[index++] = nums[i];
                }
            }

            int fillindex = index;
            while (fillindex < len) {
                nums[fillindex++] = 0;
            }
        }
    }
}
