using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ImageSmootherSolution
    {
        //O(N)2 check all the index surronding M[i, j]
        public int[,] ImageSmoother(int[,] M) {
            int row = M.GetLength(0);
            int col = M.GetLength(1);
            int[,] result = new int[row, col];
            double count = 0;
            double sum = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sum = M[i, j];
                    count = 1;

                    if (i - 1 >= 0)
                    {
                        sum += M[i - 1, j];
                        count++;
                    }
                    if (i + 1 < row)
                    {
                        sum += M[i + 1, j];
                        count++;
                    }
                    if (j - 1 >= 0)
                    {
                        sum += M[i, j - 1];
                        count++;
                    }
                    if (j + 1 < col)
                    {
                        sum += M[i, j + 1];
                        count++;
                    }
                    if (i - 1 >= 0 && j - 1 >= 0)
                    {
                        sum += M[i - 1, j - 1];
                        count++;
                    }
                    if (i + 1 < row && j - 1 >= 0)
                    {
                        sum += M[i + 1, j - 1];
                        count++;
                    }
                    if (i - 1 >= 0 && j + 1 < col)
                    {
                        sum += M[i - 1, j + 1];
                        count++;
                    }
                    if (i + 1 < row && j + 1 < col)
                    {
                        sum += M[i + 1, j + 1];
                        count++;
                    }
                    result[i, j] = (int)Math.Floor(sum / count);
                }
            }

            return result;
        }
    }
}
