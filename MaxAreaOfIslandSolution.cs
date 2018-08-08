using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MaxAreaOfIslandSolution
    {
        //DFS if grid[i, j] == 1 Set grid[i, j] = -1
        public int MaxAreaOfIsland(int[,] grid) {
            int row = grid.GetLength(0);
            int col = grid.GetLength(1);
            int result = 0;

            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    result = Math.Max(result, DFS(grid, i, j));
                }
            }

            return result;
        }

        public int DFS(int[,] arr, int r, int c) {
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);
            if (r < 0 || r >= row || c < 0 || c >= col || arr[r, c] == -1 || arr[r, c] == 0)  {
                return 0;
            }
            int sum = 1;
            arr[r, c] = -1;
            sum += DFS(arr, r - 1, c) + DFS(arr, r + 1, c) + DFS(arr, r, c - 1) + DFS(arr, r, c + 1);
            return sum;
        }
    }
}
