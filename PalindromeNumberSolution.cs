using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PalindromeNumberSolution
    {
        //toString()
        public bool IsPalindrome(int x) {
            string s = x.ToString();
            int len = s.Length;
            if (x < 0) {
                return false;
            }
            if (len == 1) {
                return true;
            }

            int left = 0;
            int right = len - 1;
            while (left < right) {
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                }
                else {
                    return false;
                }
                
            }

            return true;
        }
    }
}
