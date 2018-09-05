using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //1.Fill the Dictionary for List1 2. check if List2 dc[list2[i]] + i < min
    public class MinimumIndexSumOfTwoListsSolution
    {
        public string[] FindRestaurant(string[] list1, string[] list2) {
            int len1 = list1.Length;
            int len2 = list2.Length;
            Dictionary<string, int> dc = new Dictionary<string, int>();
            int min = len1 + len2;
            string s = "";

            for (int i = 0; i < len1; i++)
            {
                if (!dc.Keys.Contains(list1[i]))
                {
                    dc[list1[i]] = i;
                }
            }

            List<string> ls = new List<string>();
            for (int i = 0; i < len2; i++)
            {
                if (dc.Keys.Contains(list2[i]))
                {
                    if (dc[list2[i]] + i == min)
                    {
                        ls.Add(list2[i]);
                    }
                    if (dc[list2[i]] + i < min)
                    {
                        if (ls.Count != 0)
                        {
                            ls.Clear();
                        }
                        s = list2[i];
                        ls.Add(list2[i]);
                        min = dc[list2[i]] + i;
                    }                    
                }
            }

            string[] arr = new string[ls.Count];
            int idx = 0;

            foreach (var str in ls) {
                arr[idx++] = str;
            }

            return arr;
        }
    }
}
