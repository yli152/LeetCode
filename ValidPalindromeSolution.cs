using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //Two pointer while()
    public class ValidPalindromeSolution
    {
        public bool IsPalindrome(string s) {
            int left = 0;
            int right = s.Length - 1;
            s = s.ToLower();

            while (left < right)
            {

                while (left < right)
                {
                    if (s[left] <= 122 && s[left] >= 97)
                    {
                        break;
                    }
                    left++;
                }

                while (left < right)
                {
                    if (s[right] <= 122 && s[right] >= 97)
                    {
                        break;
                    }
                    right--;
                }

                if (s[left] != s[right])
                {
                    return false;
                }
                else
                {
                    left++;
                    right--;
                }
            }

            return true;
        }
    }
}
