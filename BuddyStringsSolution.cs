using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class BuddyStringsSolution
    {
        //First, using stringbuilder. Second, 分情况 A == B / A != B(换一次看看相不相等)
        public bool BuddyStrings(string A, string B) {
            int lenA = A.Length;
            StringBuilder sba = new StringBuilder();
            sba.Append(A);
            int lenB = B.Length;
            StringBuilder sbb = new StringBuilder();
            sbb.Append(B);
            bool flag = true;

            if (lenA == 0 || lenB == 0 || lenA != lenB) {
                return false;
            }

            if (A == B) {
                if (lenA == 1) {
                    return false;
                }
                for (int i = 0; i < lenA - 1; i++) {
                    for (int j = i + 1; j < lenA; j++) {
                        if (A[i] == A[j]) {
                            return true;
                        }
                    }
                }
                return false;
            }

            for (int i = 0; i < lenA; i++) {
                if (A[i] != B[i]) {
                    if (i == lenA - 1 && flag)
                    {
                        return false;
                    }
                    else {
                        for (int j = i + 1; j < lenA; j++)
                        {
                            if (A[j] != B[j]) {
                                char temp = sba[i];
                                sba[i] = sba[j];
                                sba[j] = temp;
                                flag = false;
                                if (sba.ToString() != sbb.ToString()) {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}
