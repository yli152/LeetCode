using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RotatedDigitsSolution
    {
        //stupid question
        public int RotatedDigits(int N) {
            int result = 0;

            for (int i = 0; i <= N; i++) {
                if (i.ToString().Contains('2') || i.ToString().Contains('5') || i.ToString().Contains('6') || i.ToString().Contains('9')) {
                    if (!i.ToString().Contains('3') || !i.ToString().Contains('4') || !i.ToString().Contains('7')) {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
