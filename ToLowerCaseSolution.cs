using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ToLowerCaseSolution
    {
        //ASCII
        public string ToLowerCase(string str) {
            int len = str.Length;
            StringBuilder sb = new StringBuilder();
            sb.Append(str);

            for (int i = 0; i < len; i++)
            {
                if (str[i] >= 65 && str[i] <= 90)
                {
                    sb[i] = (char)(str[i] + 32);
                }
            }

            return sb.ToString();
        }
    }
}
