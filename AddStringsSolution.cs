using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class AddStringsSolution
    {
        //sb.Insert(0, (x + y + carry) % 10); carry = (x + y + carry) / 10;
        public string AddStrings(string num1, string num2) {
            StringBuilder sb = new StringBuilder();
            int carry = 0;
            int len1 = num1.Length;
            int len2 = num2.Length;

            for (int i = len1 - 1, j = len2 - 1; i >= 0 || j >= 0 || carry == 1; i--, j--)
            {
                int x = i < 0 ? 0 : num1[i] - '0';
                int y = j < 0 ? 0 : num2[j] - '0';
                sb.Insert(0, (x + y + carry) % 10);
                carry = (x + y + carry) / 10;
            }

            return sb.ToString();
        }
    }
}
