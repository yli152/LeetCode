﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PascalTriangleIISolution
    {
        //using array to understand to see each iteration, adding 1 each time and then change the values between two 1s
        public List<int> GetRow(int rowIndex) {
            List<int> result = new List<int>();
            result.Add(1);

            for (int i = 1; i <= rowIndex; i++) {
                result.Add(1);
                for (int j = i - 1; j > 0; j--) {
                    result[j] = result[j] + result[j - 1];
                }
            }

            return result;
        }
    }
}
