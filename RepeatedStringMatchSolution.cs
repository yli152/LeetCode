using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RepeatedStringMatchSolution
    {
        //!!!
        public int RepeatedStringMatch(string A, string B) {
            //Java accepted Solution:
            //int len = B.length() / A.length() + 2;
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < len; i++)
            //{
            //    sb.append(A);
            //    if (sb.toString().contains(B)) return i + 1;
            //}
            //return -1;

            StringBuilder sb = new StringBuilder();
            sb.Append(A);
            int c = (int)Math.Ceiling((double)B.Length / A.Length);

            int i = 1;

            //Make A atleast of size length B.
            while (i < c)
            {
                sb.Append(A);
                i++;
            }

            int repcount = i;

            while (sb.ToString().IndexOf(B) < 0)
            {
                sb.Append(A);
                if (sb.Length > B.Length && sb.ToString().IndexOf(B) < 0)
                {
                    return -1;
                }
                ++repcount;

            }

            return repcount;
        }
    }
}
