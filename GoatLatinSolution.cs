using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //分情况讨论
    public class GoatLatinSolution
    {
        public string ToGoatLatin(string S) {
            string[] arr = S.Split(' ');
            int len = arr.Length;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < len; i++)
            {
                if (arr[i][0] == 'a' || arr[i][0] == 'e' || arr[i][0] == 'i' || arr[i][0] == 'o' || arr[i][0] == 'u' || arr[i][0] == 'A' || arr[i][0] == 'E' || arr[i][0] == 'I' || arr[i][0] == 'O' || arr[i][0] == 'U')
                {
                    sb.Append(arr[i] + "ma");
                }
                else
                {
                    int lenw = arr[i].Length;
                    for (int j = 1; j < lenw; j++)
                    {
                        sb.Append(arr[i][j]);
                    }
                    sb.Append(arr[i][0] + "ma");
                }

                for (int k = 0; k < i + 1; k++)
                {
                    sb.Append("a");
                }

                if (i != len - 1) {
                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }
    }
}
