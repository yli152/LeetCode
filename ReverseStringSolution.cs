using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //1.StringBuilder 2.S.toCharArray() --> two pointer 3.creat a new Array
    public class ReverseStringSolution
    {
        public string ReverseString(string s) {
            StringBuilder result = new StringBuilder();
            int len = s.Length;
 
            for (int i = len - 1; i >= 0; i--)
            {
                result.Append(s[i]);
            }
            return result.ToString();
        }
    }
}
