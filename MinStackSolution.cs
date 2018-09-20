using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //Two stacks Min stack is to store current min value
    public class MinStackSolution
    {
        Stack<int> Values;
        Stack<int> Min;
        /** initialize your data structure here. */
        public MinStackSolution()
        {
            Values = new Stack<int>();
            Min = new Stack<int>();
        }

        public void Push(int x)
        {
            Values.Push(x);
            if (Min.Count == 0 || x <= GetMin())
            {
                Min.Push(x);
            }
        }

        public void Pop()
        {
            int popped = Values.Pop();
            if (popped == GetMin())
            {
                Min.Pop();
            }
        }

        public int Top()
        {
            return Values.Count == 0 ? 0 : Values.Peek();
        }

        public int GetMin()
        {
            return Min.Count == 0 ? 0 : Min.Peek();
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(x);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
}
