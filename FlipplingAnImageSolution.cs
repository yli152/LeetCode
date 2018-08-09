using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class FlipplingAnImageSolution
    {
        //revert first / j < col / 2 / focus on the middle one if col is odd
        public int[][] FlipAndInvertImage(int[][] A) {
            int row = A.Length;
            int col = A[0].Length;

            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col / 2; j++) {
                   A[i][j] = A[i][j] == 0 ? 1 : 0;
                   A[i][col - 1 - j] = A[i][col - 1- j] == 0 ? 1 : 0;
                   int temp = A[i][j];
                   A[i][j] = A[i][col - 1 - j];
                   A[i][col - j] = temp;
                }
            }

            return A;
        }
    }
}
