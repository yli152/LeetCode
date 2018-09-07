using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class DesignHashSetSolution
    {
        bool[] arr;
        /** Initialize your data structure here. */
        public DesignHashSetSolution()
        {
            arr = new bool[1000000];
        }

        public void Add(int key)
        {
            arr[key] = true;
        }

        public void Remove(int key)
        {
            arr[key] = false;
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            return arr[key];
        }
    }

    /**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
}
