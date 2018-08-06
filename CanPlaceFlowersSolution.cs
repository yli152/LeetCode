using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class CanPlaceFlowersSolution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n) {
            int len = flowerbed.Length;

            if (n == 0)
            {
                return true;
            }

            if (len == 1)
            {
                if (flowerbed[0] == 0 && n <= 1)
                {
                    return true;
                }
                return false;
            }

            if (len == 2)
            {
                if (flowerbed[0] == 0 && flowerbed[1] == 0 && n <= 1)
                {
                    return true;
                }
                return false;
            }

            if (flowerbed[0] == 0 && flowerbed[1] == 0)
            {
                n--;
                flowerbed[0] = 1;
                if (n <= 0)
                {
                    return true;
                }
            }

            if (flowerbed[len - 2] == 0 && flowerbed[len - 1] == 0)
            {
                n--;
                if (n <= 0)
                {
                    return true;
                }
            }

            for (int i = 1; i < len - 1; i++)
            {
                if (n <= 0)
                {
                    return true;
                }

                if (flowerbed[i] == 0 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }

            return false;

            //concise solution same idea
            //if (n <= 0) return true;
            //for (int i = 0; i < flowerbed.length; i++)
            //{
            //    if (flowerbed[i] == 0)
            //    {
            //        if ((i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.length - 1 || flowerbed[i + 1] == 0))          
            //        {
            //            flowerbed[i] = 1;
            //            if (--n == 0) return true;
            //        }
            //    }
            //}
            //return false;
        }
    }
}
