using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //Heron's formula S = (A + B + C) / 2
    public class LargestTriangleAreaSolution
    {
        public double LargestTriangleArea(int[][] points)
        {
            int N = points.Length;
            double result = 0;

            for (int i = 0; i < N; i++)
                for (int j = i + 1; j < N; j++)
                    for (int k = j + 1; k < N; k++)
                        result = Math.Max(result, Area(points[i], points[j], points[k]));
            return result;
        }

        public double Area(int[] P, int[] Q, int[] R)
        {
            return 0.5 * Math.Abs(P[0] * Q[1] + Q[0] * R[1] + R[0] * P[1] - P[1] * Q[0] - Q[1] * R[0] - R[1] * P[0]);
        }
    }
}
