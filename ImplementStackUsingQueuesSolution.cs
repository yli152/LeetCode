using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //queue.Enqueue(q.Dequeue()) ! i < q.Count - 1
    public class ImplementStackUsingQueuesSolution
    {
        Queue<int> q;
        /** Initialize your data structure here. */
        public ImplementStackUsingQueuesSolution() {
            q = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            q.Enqueue(x);
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            q.Reverse();
            return q.Dequeue();
        }

        /** Get the top element. */
        public int Top()
        {
            return q.Reverse().First();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return q == null ? true : false;
        }
    }

    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */
}
