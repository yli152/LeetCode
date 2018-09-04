using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //O(N)2 check四边
    public class IslandPerimeterSolution
    {
        public int IslandPerimeter(int[,] grid) {
            int row = grid.GetLength(0);
            int col = grid.GetLength(1);
            int result = 0;

            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    if (grid[i, j] == 1) {
                        if (i == 0 || grid[i - 1, j] == 0) {
                            result++;
                        }
                        if (j == 0 || grid[i, j - 1] == 0) {
                            result++;
                        }
                        if (i == row - 1 || grid[i + 1, j] == 0) {
                            result++;
                        }
                        if (j == col - 1 || grid[i, j + 1] == 0) {
                            result++;
                        }
                    }
                }
            }

            return result;
        }
    }
}
