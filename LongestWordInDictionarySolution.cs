using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //HashSet 1. Sort 2. hs.Contains(0, word.Length -1)
    public class LongestWordInDictionarySolution
    {
        public string LongestWord(string[] words) {
            Array.Sort(words);
            HashSet<string> hs = new HashSet<string>();
            string result = "";

            foreach (var word in words) {
                int len = word.Length;
                if (len == 1 || hs.Contains(word.Substring(0, len - 1))) {
                    hs.Add(word);
                    if (len > result.Length) {
                        result = word;
                    }
                }
            }

            return result;
        }
    }
}
