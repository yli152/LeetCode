using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RomanToIntegerSolution
    {
        //Dictionary
        public int RomanToInt(string s) {
            int len = s.Length;
            if (s == null || len == 0) {
                return 0;
            }
            Dictionary<char, int> dc = new Dictionary<char, int>();
            dc['I'] = 1;
            dc['V'] = 5;
            dc['X'] = 10;
            dc['L'] = 50;
            dc['C'] = 100;
            dc['D'] = 500;
            dc['M'] = 1000;
            int result = 0; 

            for (int i = 0; i < len; i++) {
                if (i + 1 == len)
                {
                    result += dc[s[i]];
                }
                else {
                    if (s[i] == 'I' && (s[i + 1] == 'V' || s[i + 1] == 'X') ||
                        s[i] == 'X' && (s[i + 1] == 'L' || s[i + 1] == 'C') ||
                        s[i] == 'C' && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                    {
                        result += dc[s[i + 1]] - dc[s[i]];
                        i++;
                    }
                    else {
                        result += dc[s[i]];
                    }
                }
            }

            return result;
        }
    }
}
