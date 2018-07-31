using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MajorityElementSolution
    {
        //Dictionary
        public int MajorityElement(int[] nums) {
            Dictionary<int, int> dc = new Dictionary<int, int>();
            int len = nums.Length;
            int max = 0;
            int me = -1;

            for (int i = 0; i < len; i++) {
                if (dc.ContainsKey(nums[i]))
                {
                    dc[nums[i]]++;
                }
                else {
                    dc[nums[i]] = 1;
                }
            }

            foreach (var item in dc) {
                if (item.Value > max) {
                    max = item.Value;
                    me = item.Key;
                }
            }
            return me;
        }
    }
}
