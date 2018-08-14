using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ImplementStrStrSolution
    {
        //two pointer !length of haystack should be greater than needle
        public int StrStr(string haystack, string needle) {
            int lenh = haystack.Length;
            int lenn = needle.Length;
            if (haystack == needle || lenn == 0)
            {
                return 0;
            }
            if (lenn > lenh)
            {
                return -1;
            }

            int i = 0, j = 0, result = 0;
            while (i < lenh && j < lenn)
            {
                if (haystack[i] == needle[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    i = ++result;
                    j = 0;
                }
            }

            if (j == lenn)
            {
                return result;
            }
            return -1;
        }
    }
}
