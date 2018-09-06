using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //Two Dictionaries
    public class UncommonWordsFromTwoSentencesSolution
    {
        public string[] UncommonFromSentences(string A, string B) {
            Dictionary<string, int> dca = new Dictionary<string, int>();
            Dictionary<string, int> dcb = new Dictionary<string, int>();
            string[] arra = A.Split(' ');
            string[] arrb = B.Split(' ');
            int lena = arra.Length;
            int lenb = arrb.Length;
            int idx = 0;

            while (idx < lena || idx < lenb) {
                if (idx < lena) {
                    if (dca.Keys.Contains(arra[idx]))
                    {
                        dca[arra[idx]]++;
                    }
                    else {
                        dca[arra[idx]] = 1;
                    }
                }

                if (idx < lenb)
                {
                    if (dcb.Keys.Contains(arrb[idx]))
                    {
                        dcb[arrb[idx]]++;
                    }
                    else
                    {
                        dcb[arrb[idx]] = 1;
                    }
                }
                idx++;
            }

            List<string> ls = new List<string>();
            foreach (var pair in dca) {
                if (pair.Value == 1 && !dcb.Keys.Contains(pair.Key)) {
                    ls.Add(pair.Key);
                }
            }
            foreach (var pair in dcb)
            {
                if (pair.Value == 1 && !dca.Keys.Contains(pair.Key))
                {
                    ls.Add(pair.Key);
                }
            }

            string[] result = new string[ls.Count];
            int i = 0;
            foreach (var s in ls) {
                result[i++] = s;
            }

            return result;
        }
    }
}
