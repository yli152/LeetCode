using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ReshapeTheMatrixSolution
    {
        //Tranverse nums[i,j] to fill result[idx_r, idx_c++]
        public int[,] MatrixReshape(int [,] nums, int r, int c) {
            //int[,] result = new int[r, c];
            //int[] digits = new int[r * c];
            //int row = nums.GetLength(0);
            //int col = nums.GetLength(1);

            //if (row * col != r * c) {
            //    return nums;
            //}

            //for (int i = 0; i < row; i++) {
            //    for (int j = 0; j < col; j++) {
            //        digits[i * row + j] = nums[i,j];
            //    }
            //}

            //for (int i = 0; i < r; i++) {
            //    for (int j = 0; j < c; j++) {
            //        result[i, j] = digits[i * row + j];
            //    }
            //}

            //return result;

            int row = nums.GetLength(0);
            int col = nums.GetLength(1);

            if (row * col != r * c) {
                return nums;
            }

            int[,] result = new int[r, c];
            int idx_r = 0;
            int idx_c = 0;

            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    result[idx_r, idx_c++] = nums[i, j];
                    if (idx_c == c) {
                        idx_r++;
                        idx_c = 0;
                    }
                }
            }

            return result;
        }
    }
}
