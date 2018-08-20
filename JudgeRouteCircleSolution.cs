using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class JudgeRouteCircleSolution
    {
        //(up == down) && (left == right)
        public bool JudgeCircle(string moves) {
            int len = moves.Length;
            int up = 0;
            int down = 0;
            int left = 0;
            int right = 0;

            for (int i = 0; i < len; i++) {
                if (moves[i] == 'U') {
                    up++;
                }

                if (moves[i] == 'D')
                {
                    down++;
                }

                if (moves[i] == 'L')
                {
                    left++;
                }

                if (moves[i] == 'R')
                {
                    right++;
                }
            }

            return (up == down) && (left == right);
        }
    }
}
