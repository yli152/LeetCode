using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //O(N)2
    public class CountAndSaySolution
    {
        public string CountAndSay(int n) {
            if (n == 1)
            {
                return "1";
            }
            if (n == 2) {
                return "11";
            }
            int count = 1;
            string result = "11";

            for (int i = 3; i <= n; i++)
            {
                int len = result.Length;
                string temp = "";

                for (int j = 0; j < len - 1; j++)
                {
                    if (result[j + 1] == result[j])
                    {
                        count++;
                    }
                    else
                    {
                        temp = temp + "" + count + "" + result[j];
                        count = 1;
                    }
                    if (j + 1 == len - 1)
                    {
                        temp = temp + "" + count + "" + result[j + 1];
                    }
                }
                result = temp;
                count = 1;
            }

            return result;
        }
    }
}
