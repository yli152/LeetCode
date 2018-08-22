using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //Dictionary First, using stringbuilder to remove all punctuations. Second, split with ' '
    public class MostCommonWordSolution
    {
        public string MostCommonWord(string paragraph, string[] banned) {
            paragraph = paragraph.ToLower();
            int lenp = paragraph.ToLower().Length;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lenp; i++) {
                if ((paragraph[i] >= 97 && paragraph[i] <= 122) || paragraph[i] == ' ') {
                    sb.Append(paragraph[i]);
                }
            }

            string p = sb.ToString();
            string[] arr = p.Split(' ');
            int lenarr = arr.Length;
            Dictionary<string, int> dc = new Dictionary<string, int>();

            for (int i = 0; i < lenarr; i++) {
                if (!banned.Contains(arr[i])) {
                    if (dc.Keys.Contains(arr[i])) {
                        dc[arr[i]]++;
                    } else {
                        dc[arr[i]] = 1;
                    }
                }
            }

            int max = Int32.MinValue;
            string result = "";
            foreach (var pair in dc) {
                if (pair.Value > max) {
                    max = pair.Value;
                    result = pair.Key;
                }
            }

            return result;
        }
    }
}
