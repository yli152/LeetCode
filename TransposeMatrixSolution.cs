using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class TransposeMatrixSolution
    {
        //result[i][j] = A[j][i]; / two ways to create two dimensional array： 1- int[,] arr = new int[2,3]; 2- int[][] arr = new int[2][]; arr[0] = new int[3]; arr[1] = new int[3];
        public int[][] Transpose(int[][] A) {
            int row = A.Length;
            int col = A[0].Length;
            int[][] result = new int[col][];

            for (int i = 0; i < col; i++)
            {
                result[i] = new int[row];
                for (int j = 0; j < row; j++)
                {
                    result[i][j] = A[j][i];
                }
            }

            return result;
        }
    }
}
