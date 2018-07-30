using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PascalTriangleSolution
    {
        //differential 1,2, >=3 cases
        public List<List<int>> Generate(int numRows) {
            List<List<int>> result = new List<List<int>>();
            if (numRows == 0) {
                return result;
            }
            if (numRows == 1) {
                List<int> row = new List<int>();
                row.Add(1);
                result.Add(row);
            }

            if (numRows == 2) {
                List<int> row1 = new List<int>();
                row1.Add(1);
                List<int> row2 = new List<int>();
                row2.Add(1);
                row2.Add(1);
                result.Add(row1);
                result.Add(row2);
            }

            if (numRows >= 3) {
                List<int> row1 = new List<int>();
                row1.Add(1);
                List<int> row2 = new List<int>();
                row2.Add(1);
                row2.Add(1);
                result.Add(row1);
                result.Add(row2);
                for (int i = 3; i <= numRows; i++)
                {
                    List<int> row = new List<int>();
                    row.Add(1);
                    for (int j = 1; j < i - 1; j++)
                    {
                        row.Add(result[i - 2][j - 1] + result[i - 2][j]);
                    }
                    row.Add(1);
                    result.Add(row);
                }
            }
            
            return result;
        }
    }
}
