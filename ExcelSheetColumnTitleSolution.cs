using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //A-->0, Z-->25
    public class ExcelSheetColumnTitleSolution
    {
        public string ConvertToTitle(int n) {
            string result = "";
            while (n != 0) {
                char cur = (char)((n - 1) % 26 + 65);
                n = (n - 1) / 26;
                result = cur + result;
            }

            return result;
        }
    }
}
