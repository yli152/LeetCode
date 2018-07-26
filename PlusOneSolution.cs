using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PlusOneSolution
    {
        public int[] PlusOne(int[] digits) {
            //string d = "";
            //int len = digits.Length;

            //for (int i = 0; i < len; i++)
            //{
            //    d += digits[i];
            //}

            //string n = Convert.ToInt32(d) + 1 + "";
            //int len2 = n.Length;
            //int[] result = new int[len2];

            //for (int i = 0; i < len2; i++)
            //{
            //    result[i] = Convert.ToInt32(n[i] + "");
            //}

            //return result;
            //-----------------------------------------------------------------------------
            //Solution:
            int len = digits.Length;
            bool flag = true;

            for (int i = len - 1; i > -1; i--) {
                if (flag == true)
                {
                    if (digits[i] == 9)
                    {
                        digits[i] = 0;
                    }
                    else {
                        digits[i]++;
                        flag = false;
                    }
                }                
            }

            if (flag)
            {
                int[] result = new int[len + 1];
                result[0] = 1;
                //int len2 = result.Length;
                //for (int i = 1; i < len2 - 1; i++)
                //{
                //    result[i] = 0;
                //}
                return result;
            }
            else {
                return digits;
            }
        }
    }
}
