using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class UniqueMorseCodeWordsSolution
    {
        //using list and word[i][j] - 'a' to find the Morse Code
        public int UniqueMorseRepresentations(string[] words) {
            string[] re = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            int len = words.Length;
            List<string> ls = new List<string>();
            int result = 0;

            for (int i = 0; i < len; i++) {
                StringBuilder sb = new StringBuilder();
                int lenword = words[i].Length;
                for (int j = 0; j < lenword; j++) {
                    sb.Append(re[words[i][j] - 'a']);
                }
                if (!ls.Contains(sb.ToString())) {
                    ls.Add(sb.ToString());
                    result++;
                }
            }

            return result;
        }
    }
}
