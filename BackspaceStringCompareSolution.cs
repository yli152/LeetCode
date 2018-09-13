using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //Two pointers + Stack
    public class BackspaceStringCompareSolution
    {
        public bool BackspaceCompare(string S, string T) {
            Stack<char> ss = new Stack<char>();
            Stack<char> st = new Stack<char>();
            int lens = S.Length;
            int lent = T.Length;

            for (int i = 0; i < lens; i++)
            {
                if (S[i] != '#')
                {
                    ss.Push(S[i]);
                }
                else
                {
                    if (ss.Count != 0)
                    {
                        ss.Pop();
                    }
                }
            }

            for (int i = 0; i < lent; i++)
            {
                if (T[i] != '#')
                {
                    st.Push(T[i]);
                }
                else
                {
                    if (st.Count != 0)
                    {
                        st.Pop();
                    }
                }
            }

            if (ss.Count != st.Count)
            {
                return false;
            }
            int len = ss.Count;
            for (int i = 0; i < len; i++)
            {
                if (ss.Pop() != st.Pop())
                {
                    return false;
                }
            }

            return true;
        }
    }
}
