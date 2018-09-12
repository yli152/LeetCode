using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class HeatersSolution
    {
        public int FindRadius(int[] houses, int[] heaters) {
            Array.Sort(houses);
            Array.Sort(heaters);

            int i = 0, j = 0, res = 0;
            int lenhouse = houses.Length;
            int lenheater = heaters.Length;
            while (i < lenhouse)
            {
                while (j < lenheater - 1
                    && Math.Abs(heaters[j + 1] - houses[i]) <= Math.Abs(heaters[j] - houses[i]))
                {
                    j++;
                }
                res = Math.Max(res, Math.Abs(heaters[j] - houses[i]));
                i++;
            }

            return res;
        }
    }
}
