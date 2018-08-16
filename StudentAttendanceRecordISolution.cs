using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class StudentAttendanceRecordISolution
    {
        // continuous L --> i < len - 1;
        public bool CheckRecord(string s) {
            int len = s.Length;
            int countA = 0;
            int countL = 1;

            for (int i = 0; i < len - 1; i++) {
                if (s[i] == 'A') {
                    countA++;
                    if (s[i + 1] == 'A') {
                        countA++;
                    }
                }
                if (s[i] == 'L' && s[i + 1] == 'L')
                {
                    countL++;
                }
                else {
                    countL = 1;
                }

                if (countA > 1 || countL > 2) {
                    return false;
                }
            }

            return true;
        }
    }
}
