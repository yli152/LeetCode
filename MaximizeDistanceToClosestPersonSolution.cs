using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MaximizeDistanceToClosestPersonSolution
    {
        //while
        public int MaxDistToClosest(int[] seats) {
            int len = seats.Length;
            int max = 0;
            int i = 0;
            while (i < len)
            {
                while (i < len && seats[i] == 1)
                {
                    i++;
                }

                int j = i;

                while (i < len && seats[i] == 0)
                {
                    i++;
                }

                if (j == 0 || i == len)
                {
                    max = Math.Max(max, i - j);
                }
                else
                {
                    max = Math.Max(max, (i - j + 1) / 2);
                }
            }

            return max;
        }
    }
}
