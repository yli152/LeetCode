using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class DetectCapitalSolution
    {
        //分情况讨论， 先第一位，然后第二位
        public bool DetectCapitalUse(string word) {
            int len = word.Length;
            if (len == 1)
            {
                return true;
            }

            bool result = true;

            for (int i = 1; i < len; i++)
            {
                if (word[0] >= 97 && word[0] <= 122)
                {
                    if (word[i] >= 65 && word[i] <= 90)
                    {
                        result = false;
                    }
                }
                else
                {
                    if (word[1] >= 65 && word[1] <= 90)
                    {
                        if (word[i] >= 97 && word[i] <= 122)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (word[i] >= 65 && word[i] <= 90)
                        {
                            return false;
                        }
                    }
                }
            }

            return result;
        }
    }
}
