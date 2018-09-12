using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PeakIndexInAMountainArraySolution
    {
        public int PeakIndexInMountainArray(int[] A) {
            int len = A.Length;
            int result = 0;

            for (int i = 1; i < len - 1; i++)
            {
                if (A[i] >= A[i - 1] && A[i] >= A[i + 1])
                {
                    result = i;
                }
            }

            return result;
        }
    }
}
