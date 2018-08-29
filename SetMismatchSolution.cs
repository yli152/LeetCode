﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class SetMismatchSolution
    {
        public int[] FindErrorNums(int[] nums) {
            int len = nums.Length;
            int[] hash = new int[len + 1];
            int duplicate = 0;
            int loss = 0;

            for (int i = 0; i < len; i++)
            {
                hash[nums[i]]++;
            }

            for (int i = 1; i < len + 1; i++)
            {
                if (hash[i] == 2) duplicate = i;
                if (hash[i] == 0) loss = i;
            }

            int[] res = new int[2];
            res[0] = duplicate;
            res[1] = loss;
            return res;
        }
    }
}
