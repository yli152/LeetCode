using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class AddBinarySolution
    {
        //using flag to trace 进位
        public string AddBinary(string a, string b) {
            string result = "";
            string s = "";
            int lena = a.Length;
            int lenb = b.Length;
            bool flag = false;
            string temp = "";

            if (lena > lenb) {
                for (int i = 0; i < lena - lenb; i++) {
                    s += '0';
                }
                b = s + b;
                lenb = b.Length;
            } else if (lenb > lena) {
                for (int i = 0; i < lenb - lena; i++)
                {
                    s += '0';
                }
                a = s + a;
                lena = a.Length;
            }

            for (int i = lena - 1; i >= 0; i--) {
                if (flag) {
                    if (a[i] == '0' && b[i] == '0')
                    {
                        flag = false;
                        result += '1';
                    }
                    if (a[i] == '1' && b[i] == '1') {                 
                        result += '1';
                        flag = true;
                    }
                    if ((a[i] == '1' && b[i] == '0') || (a[i] == '0' && b[i] == '1')) {
                        result += '0';
                        flag = true;
                    }
                } else {
                    if (a[i] == '1' && b[i] == '1')
                    {
                        flag = true;
                        result += '0';
                    }
                    else if (a[i] == '0' && b[i] == '0')
                    {
                        result += '0';
                    }
                    else {
                        result += '1';
                    }
                } 
            }

            if (flag) {
                result += '1';
            }

            int len2 = result.Length;
            for (int i = len2 - 1; i >= 0; i--) {
                temp += "" + result[i];
            }
            return temp;
        }
    }
}