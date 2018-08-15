using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RepeatedSubstringPatternSolution
    {
        //first s+s, and destroy the first and the last to see if the remaining contains s
        public bool RepeatedSubstringPattern(string s) {
            String s2 = s + s;
            return s2.Substring(1, s2.Length - 1).Contains(s);
        }
    }
}
