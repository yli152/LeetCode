using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class WordPatternSolution
    {
        // Same as Isismorphic string solution
        public bool WordPattern(string pattern, string str) {
            string[] arr = str.Split(' ');
            int len = pattern.Length;
            if (len != arr.Length) {
                return false;
            }
            Dictionary<char, string> dc = new Dictionary<char, string>();

            for (int i = 0; i < len; i++) {
                if (dc.Keys.Contains(pattern[i]))
                {
                    if (arr[i] != dc[pattern[i]]) {
                        return false;
                    } 
                }
                else {
                    if (dc.Values.Contains(arr[i])) {
                        return false;
                    }
                    dc[pattern[i]] = arr[i];
                }
            }

            return true;
        }
    }
}
