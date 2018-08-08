using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //using count variable to check the last three index: count == len -3, len - 2, len - 1
    public class _1BitAnd2BitCharactersSolution
    {
        public bool IsOneBitCharacter(int[] bits) {
            int len = bits.Length;
            int count = 0;
            bool result = false;

            if (len <= 2)
            {
                if (bits[0] == 0)
                {
                    return true;
                }
            }

            for (int i = 0; i < len - 1;)
            {
                if (bits[i] == 0)
                {
                    i++;
                    count++;
                }
                else
                {
                    i += 2;
                    count += 2;
                }
            }

            if (count == len - 3 || count == len - 1)
            {
                return true;
            }
            if (count == len - 2)
            {
                if (bits[count] == 0)
                {
                    return true;
                }
            }
            return result;
        }
    }
}
