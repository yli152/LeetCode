using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ValidAnagramSolution
    {
        //sort
        public bool IsAnagram(string s, string t) {
            char[] sarr = s.ToCharArray();
            Array.Sort(sarr);
            char[] tarr = t.ToCharArray();
            Array.Sort(tarr);
            int lens = sarr.Length;
            int lent = tarr.Length;
            if (lens != lent) {
                return false;
            }

            for (int i = 0; i < lens; i++) {
                if (sarr[i] != tarr[i]) {
                    return false;
                }
            }

            return true;
        }
    }
}
