using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //s2.push(s1.pop())
    class ImplementQueueUsingStacksSolution
    {
        Stack<int> s1;
        Stack<int> s2;
        /** Initialize your data structure here. */
        public ImplementQueueUsingStacksSolution()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            s1.Push(x); 
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (s2.Count == 0) {
                while (s1.Count != 0) {
                    s2.Push(s1.Pop());
                }
            }
            return s2.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            if (s2.Count == 0)
            {
                while (s1.Count != 0)
                {
                    s2.Push(s1.Pop());
                }
            }
            return s2.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return s1.Count == 0 && s2.Count == 0;
        }
    }

    /**
    * Your MyQueue object will be instantiated and called as such:
    * MyQueue obj = new MyQueue();
    * obj.Push(x);
    * int param_2 = obj.Pop();
    * int param_3 = obj.Peek();
    * bool param_4 = obj.Empty();
    */
}
