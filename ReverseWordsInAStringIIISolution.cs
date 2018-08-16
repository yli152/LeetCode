using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ReverseWordsInAStringIIISolution
    {
        //(split -> char[] -> switch) --> StringBuilder
        public string ReverseWords(string s) {
            string[] arr = s.Split(' ');
            int len = arr.Length;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < len; i++) {
                char[] word = arr[i].ToCharArray();
                int left = 0;
                int right = word.Length - 1;
                while (left < right) {
                    char temp = word[left];
                    word[left] = word[right];
                    word[right] = temp;
                    left++;
                    right--;
                }
                if (i == len - 1) {
                    sb.Append(word);
                } else {
                    sb.Append(word).Append(" ");
                }
            }

            return sb.ToString();
        }
    }
}
