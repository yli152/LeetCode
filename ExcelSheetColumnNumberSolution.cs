﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ExcelSheetColumnNumberSolution
    {
        //sum *= 26; sum += c - 'A' + 1;
        //"B" = 2
        //"BC" = (2)26 + 3
        //"BCM" = (2(26) + 3)26 + 13
        public int titleToNumber(string s) {
            if (s == null) {
                return -1;
            }
            int sum = 0;

            foreach (char c in s.ToUpper().ToCharArray()) {
                sum *= 26;
                sum += c - 'A' + 1;
            }

            return sum;
        }
    }
}
