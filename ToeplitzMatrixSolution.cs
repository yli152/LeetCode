using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ToeplitzMatrixSolution
    {
        //matrix[i, j] != matrix[i + 1, j + 1]
        public bool IsToeplitzMatrix(int[,] matrix) {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            bool result = true;

            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    if (i + 1 < row && j + 1 < col) {
                        if (matrix[i, j] != matrix[i + 1, j + 1]) {
                            return false;
                        }
                    }
                }
            }

            return result;
        }
    }
}
