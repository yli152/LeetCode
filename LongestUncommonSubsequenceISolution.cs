using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LongestUncommonSubsequenceISolution
    {
        //stupid question
        public int FindLUSlength(string a, string b) {
            int lena = a.Length;
            int lenb = b.Length; 

            if (lena == 0 && lenb == 0) {
                return -1;
            }

            if (lena != lenb)
            {
                return Math.Max(lena, lenb);
            }
            else {
                if (a == b)
                {
                    return -1;
                }
                else {
                    return lena;
                }
            }
        }
    }
}
