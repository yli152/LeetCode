using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class NumberOfSegmentsInAStringSolution
    {
        //split and check if arr[i] == ""
        public int CountSegments(string s) {
            string[] arr = s.Split(' ');
            int len = arr.Length;
            int result = 0;
            
            for (int i = 0; i < len; i++) {
                if (arr[i] != "") {
                    result++;
                }
            }

            return result;
        }
    }
}
