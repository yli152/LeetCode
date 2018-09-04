using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //Time limit exceeds JAVA can pass
    public class FindAllAnagramsInAStringSolution
    {
        public IList<int> FindAnagrams(string s, string p) {
            int lens = s.Length;
            int lenp = p.Length;
            IList<int> result = new List<int>();
            if (lens < lenp || lens == 0) {
                return result;
            }
            
            for (int i = 0; i <= lens - lenp; i++) {
                if (p.Contains(s[i]) && ValidAnagram(s.Substring(i, lenp), p)) {
                    result.Add(i);
                }
            }

            return result;
        }

        public bool ValidAnagram(string a, string b) {
            char[] aarr = a.ToCharArray();
            Array.Sort(aarr);
            char[] barr = b.ToCharArray();
            Array.Sort(barr);
            int len = a.Length;

            for (int i = 0; i < len; i++) {
                if (aarr[i] != barr[i]) {
                    return false;
                }
            }

            return true;
        }
    }
}
