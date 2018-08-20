using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ValidPalindromeIISolution
    {
        //recursive with individually IsPalindrome function IsPalindrome(s, left, right - 1) || IsPalindrome(s, left + 1, right)
        public bool ValidPalindrome(string s) {
            int len = s.Length;
            int left = -1;
            int right = len;

            while (left < right) {
                if (s[left] != s[right]) {
                    return IsPalindrome(s, left, right - 1) || IsPalindrome(s, left + 1, right);
                }
                left++;
                right--;
            }
            return true;
        }

        public bool IsPalindrome(string s, int l, int r) {
            while (l < r) {
                if (s[l] != s[r]) {
                    return false;
                }
                l++;
                r--;
            }
            return true;
        }
    }
}
