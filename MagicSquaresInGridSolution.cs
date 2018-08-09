using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //O(N)2 check every element surronding 8 directions
    public class MagicSquaresInGridSolution
    {
        public int NumMagicSquareInside(int[][] grid) {
            int row = grid.Length;
            int col = grid[0].Length;
            int sumThree = 0;
            int result = 0;

            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    if (i + 1 < row && j + 1 <col && i - 1 >= 0 && j - 1 >= 0) {
                        sumThree = grid[i - 1][j - 1] + grid[i][j] + grid[i + 1][j + 1];
                        if ((grid[i - 1][j - 1] - 9 <= 0 && grid[i - 1][j - 1] != 0 && grid[i - 1][j] != 0 && grid[i - 1][j] - 9 <= 0 && grid[i - 1][j - 1] != 0 && grid[i - 1][j - 1] - 9 <= 0 && grid[i][j - 1] != 0 && grid[i][j - 1] - 9 <= 0 && grid[i][j] != 0 && grid[i][j] - 9 <= 0 && grid[i][j + 1] != 0 && grid[i][j + 1] - 9 <= 0 && grid[i + 1][j - 1] != 0 && grid[i + 1][j - 1] - 9 <= 0 && grid[i + 1][j] != 0 && grid[i + 1][j] - 9 <= 0 && grid[i + 1][j + 1] != 0 && grid[i + 1][j + 1] - 9 <= 0) &&
                            grid[i - 1][j] + grid[i][j] + grid[i + 1][j] == sumThree &&
                            grid[i - 1][j + 1] + grid[i][j] + grid[i + 1][j - 1] == sumThree &&
                            grid[i][j - 1] + grid[i][j] + grid[i][j + 1] == sumThree 
                            ) {
                            result++;
                        }
                    }
                }
            }

            return result;
        }
    }
}
