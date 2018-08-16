using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ReverseStringIISolution
    {
        //StringBuilder, 分两种情况 len - i >= k, 自己写Reverse
        public string ReverseStr(string s, int k) {
            StringBuilder sb = new StringBuilder(); ;
            sb.Append(s);
            int len = sb.Length;

            for (int i = 0; i < len; i += 2 * k) {
                if (len - i >= k)
                {
                    Reverse(sb, i, i + k - 1);
                }
                else {
                    Reverse(sb, i, len - 1);
                }
            }

            return sb.ToString();
        }

        public void Reverse(StringBuilder s, int left, int right) {
            while (left < right) {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right--;
            }
        }
    }
}
