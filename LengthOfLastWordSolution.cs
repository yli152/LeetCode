using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //split
    public class LengthOfLastWordSolution
    {
        public int LengthOfLastWord(string s) {
            if (s.Length == 0)
            {
                return 0;
            }
            string[] arr = s.Split(' ');
            int len = arr.Length;

            for (int i = len - 1; i >= 0; i--)
            {
                if (arr[i] != "")
                {
                    return arr[i].Length;

                }
            }

            return 0;
        }
    }
}
