using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class NumberOfBoomerangsSolution
    {
        //HashSet / O(N)2 / store the distance appearing times and result += 2 * dc[distance]
        public int numberOfBoomerangs(int[,] points) {
            int lenr = points.GetLength(0);
            if (lenr < 3)
            {
                return 0;
            }
            
            int result = 0;

            for (int i = 0; i < lenr; i++)
            {
                Dictionary<int, int> dc = new Dictionary<int, int>();
                for (int j = 0; j < lenr; j++)
                {
                    if (j != i)
                    {
                        int distance = (points[i, 1] - points[j, 1]) * (points[i, 1] - points[j, 1]) + (points[i, 0] - points[j, 0]) * (points[i, 0] - points[j, 0]);
                        if (!dc.Keys.Contains(distance))
                        {
                            dc[distance] = 1;
                        }
                        else
                        {
                            result += 2 * dc[distance];
                            dc[distance]++;
                        }
                    }
                }
            }

            return result;
        }
    }
}
