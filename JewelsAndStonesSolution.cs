using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //HashSet
    public class JewelsAndStonesSolution
    {
        public int NumJewelsInStones(string J, string S) {
            int lenj = J.Length;
            int lens = S.Length;
            HashSet<char> hs = new HashSet<char>();

            for (int i = 0; i < lenj; i++) {
                hs.Add(J[i]);
            }

            int result = 0;
            for (int i = 0; i < lens; i++) {
                if (hs.Contains(S[i])) {
                    result++;
                }
            }

            return result;
        }
    }
}
