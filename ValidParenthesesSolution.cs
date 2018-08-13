using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ValidParenthesesSolution
    {
        //stack "{[(" push to stack / "}])" pop() to compare
        public bool IsValid(string s) {
            int len = s.Length;
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < len; i++)
            {
                if (s[i] == '{' || s[i] == '(' || s[i] == '[')
                {
                    st.Push(s[i]);
                }
                else
                {
                    if (st.Count != 0)
                    {
                        if (s[i] == '}' && st.Pop() != '{')
                        {
                            return false;
                        }
                        if (s[i] == ')' && st.Pop() != '(')
                        {
                            return false;
                        }
                        if (s[i] == ']' && st.Pop() != '[')
                        {
                            return false;
                        }
                    }
                    else {
                        return false;
                    }
                }
            }
            
            return true;
        }
    }
}
