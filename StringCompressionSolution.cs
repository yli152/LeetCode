using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class StringCompressionSolution
    {
        public int Compress(char[] chars) {
            int len = chars.Length;
            if (len == 1)
            {
                return 1;
            }
            int count = 1;
            int idx = 0;
            bool flag = true;

            for (int i = 0; i < len - 1; i++)
            {
                if (chars[i] == chars[i + 1])
                {
                    if (flag)
                    {
                        chars[idx++] = chars[i];
                        flag = false;
                    }
                    count++;
                    if (i == len - 2)
                    {
                        for (int j = 0; j < count.ToString().Length; j++)
                        {
                            chars[idx++] = count.ToString()[j];
                        }
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        chars[idx++] = chars[0];
                    }
                    else
                    {
                        if (count > 1)
                        {
                            for (int j = 0; j < count.ToString().Length; j++)
                            {
                                chars[idx++] = count.ToString()[j];
                            }
                            flag = true;
                            count = 1;
                            if (i == len - 2)
                            {
                                chars[idx++] = chars[len - 1];
                            }
                        }
                        else
                        {
                            chars[idx++] = chars[i];
                            if (i == len - 2)
                            {
                                chars[idx++] = chars[len - 1];
                            }
                        }
                    }
                }
            }

            return idx;
        }
    }
}
