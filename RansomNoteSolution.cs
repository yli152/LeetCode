using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RansomNoteSolution
    {
        //Dictionary 2O(N)
        public bool CanConstruct(string ransomNote, string magazine) {
            int lenr = ransomNote.Length;
            int lenm = magazine.Length;
            if (lenr == 0)
            {
                return true;
            }
            else if (lenm == 0)
            {
                return false;
            }

            Dictionary<char,int> dc = new Dictionary<char, int>();

            for (int i = 0; i < lenm; i++) {
                if (dc.ContainsKey(magazine[i]))
                {
                    dc[magazine[i]]++;
                }
                else {
                    dc[magazine[i]] = 1;
                }
            }

            for (int i = 0; i < lenr; i++) {
                if (dc.ContainsKey(ransomNote[i]))
                {
                    if (dc[ransomNote[i]] == 0) {
                        return false;
                    } else {
                        dc[ransomNote[i]]--;
                    }
                }
                else {
                    return false;
                }
            }

            return true;
        }
    }
}
