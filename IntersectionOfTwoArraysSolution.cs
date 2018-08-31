using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //Dictionary List --> int[]
    public class IntersectionOfTwoArraysSolution
    {
        public int[] Intersection(int[] nums1, int[] nums2) {
            int len1 = nums1.Length;
            int len2 = nums2.Length;
            Dictionary<int, bool> dc = new Dictionary<int, bool>();

            for (int i = 0; i < len1; i++) {
                if (!dc.Keys.Contains(nums1[i])) {
                    dc[nums1[i]] = true;
                }
            }

            List<int> ls = new List<int>();

            for (int i = 0; i < len2; i++) {
                if (dc.Keys.Contains(nums2[i]) && dc[nums2[i]]) {
                    ls.Add(nums2[i]);
                    dc[nums2[i]] = false;
                }
            }

            int[] result = new int[ls.Count];
            int idx = 0;
            foreach (var i in ls) {
                result[idx++] = i;
            }

            return result;
        }
    }
}
