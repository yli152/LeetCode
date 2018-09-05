using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //Dictionary string one, two, three
    public class KeyboardRowSolution
    {
        public string[] FindWords(string[] words) {
            string one = "qwertyuiop";
            string two = "asdfghjkl";
            string three = "zxcvbnm";
            string combo = one + two + three;
            int lenc = combo.Length;
            int lenw = words.Length;
            Dictionary<char, int> dc = new Dictionary<char, int>();

            for (int i = 0; i < lenc; i++) {
                if (!dc.Keys.Contains(combo[i])) {
                    if (one.Contains(combo[i])) dc[combo[i]] = 1;
                    if (two.Contains(combo[i])) dc[combo[i]] = 2;
                    if (three.Contains(combo[i])) dc[combo[i]] = 3;
                }
            }

            List<string> ls = new List<string>();
            for (int i = 0; i < lenw; i++) {
                string temp = words[i].ToLower();
                int len = temp.Length;
                bool flag = true;
                if (len == 1) {
                    ls.Add(temp);
                } else {
                    int row = dc[temp[0]];
                    for (int j = 1; j < len; j++)
                    {
                        if (dc[temp[j]] != row) {
                            flag = false;
                        }
                    }
                    if (flag) {
                        ls.Add(words[i]);
                    }
                }
            }

            string[] result = new string[ls.Count];
            int idx = 0;
            foreach (var i in ls) {
                result[idx++] = i;
            }

            return result;
        }
    }
}
