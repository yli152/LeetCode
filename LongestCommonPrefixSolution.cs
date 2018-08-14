using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LongestCommonPrefixSolution
    {
        //First find out the word with min length, and then O(N)2 to tranverse
        public string LongestCommonPrefix(string[] strs) {
            int len = strs.Length;
            if (len == 0)
            {
                return "";
            }
            if (len == 1)
            {
                return strs[0];
            }

            int min = strs[0].Length;
            int idx = 0;
            for (int i = 0; i < len; i++)
            {
                if (strs[i].Length < min)
                {
                    min = strs[i].Length;
                    idx = i;
                }
            }

            string result = "";
            for (int i = 0; i < strs[idx].Length; i++)
            {
                char c = strs[idx][i];
                bool flag = true;
                for (int j = 0; j < len; j++)
                {
                    if (strs[j][i] != c)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    result += c;
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}
