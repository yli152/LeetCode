using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class IntersectionOfTwoArraysIISolution
    {
        //Dictionary dc[nums2[i]]--;
        public int[] Intersect(int[] nums1, int[] nums2) {
            int len1 = nums1.Length;
            int len2 = nums2.Length;
            Dictionary<int, int> dc = new Dictionary<int, int>();
            List<int> ls = new List<int>();

            for (int i = 0; i < len1; i++) {
                if (dc.Keys.Contains(nums1[i])) {
                    dc[nums1[i]]++;
                } else {
                    dc[nums1[i]] = 1;
                }
            }

            for (int i = 0; i < len2; i++) {
                if (dc.Keys.Contains(nums2[i]) && dc[nums2[i]] > 0) {
                    ls.Add(nums2[i]);
                    dc[nums2[i]]--;
                }
            }

            int[] result = new int[ls.Count];
            int idx = 0;
            foreach (var n in ls) {
                result[idx++] = n;
            }

            return result;
        }
    }
}
