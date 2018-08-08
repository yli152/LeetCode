using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //Dictionary<int, int[]> [0]: count, [1]: first appearing index, [2]: current index
    public class DegreeOfAnArraySolution
    {
        public int FindShortestSubArray(int[] nums) {
            int len = nums.Length;
            Dictionary<int, int[]> dc = new Dictionary<int, int[]>();
            int max = 0;
            int result = len;
            

            for (int i = 0; i < len; i++) {
                if (dc.Keys.Contains(nums[i]))
                {
                    dc[nums[i]][0]++;
                    dc[nums[i]][2] = i;
                }
                else {
                    int[] arr = new int[3];
                    arr[0] = 1;
                    arr[1] = i;
                    arr[2] = i;
                    dc[nums[i]] = arr;
                }
            }

            foreach (var item in dc.Keys) {
                if (dc[item][0] > max)
                {
                    max = dc[item][0];
                    result = dc[item][2] - dc[item][1] + 1;
                }
                else if (dc[item][0] == max) {
                    result = Math.Min(result, dc[item][2] - dc[item][1] + 1); 
                }
            }

            return result;
        }
    }
}
