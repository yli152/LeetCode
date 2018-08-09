using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PositionsOfLargeGroupsSolution
    {
        //using count, startIndex, endIndex to tranverse the string
        public IList<IList<int>> LargeGroupPositions(string S)
        {
            IList<IList<int>> result = new List<IList<int>>();
            int len = S.Length;
            int count = 1;
            int start = 0;
            int end = 0;

            if (len < 3)
            {
                return result;
            }

            for (int i = 0; i < len - 1; i++)
            {
                if (S[i] == S[i + 1])
                {
                    end++;
                    count++;
                    if (i + 1 == len - 1 && count >= 3)
                    {
                        List<int> ls = new List<int>();
                        ls.Add(start);
                        ls.Add(end);
                        result.Add(ls);
                    }
                }
                else
                {
                    if (count >= 3)
                    {
                        List<int> ls = new List<int>();
                        ls.Add(start);
                        ls.Add(end);
                        result.Add(ls);
                    }
                    count = 1;
                    start = i + 1;
                    end = i + 1;
                }
            }

            return result;
        }
    }
}
