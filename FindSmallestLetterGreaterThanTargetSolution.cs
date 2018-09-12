using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //return letters[left]
    public class FindSmallestLetterGreaterThanTargetSolution
    {
        public char NextGreatestLetter(char[] letters, char target) {
            int len = letters.Length;
            int left = 0;
            int right = len - 1;

            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (letters[mid] > target) {
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            }

            return left >= len ? letters[0] : letters[left];
        }
    }
}
