using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class SelfDividingNumbersSolution
    {
        public IList<int> SelfDividingNumbers(int left, int right) {
            IList<int> result = new List<int>();

            for (int i = left; i <= right; i++) {
                bool flag = true;
                int temp = i;
                while (temp != 0) {
                    int digit = temp % 10;
                    if (digit == 0 || i % digit != 0) {
                        flag = false;
                        break;
                    }
                    temp /= 10;
                }
                if (flag) {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
