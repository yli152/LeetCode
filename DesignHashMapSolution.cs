﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //int array int[i] = -1
    public class DesignHashMapSolution
    {
        int[] map;
        /** Initialize your data structure here. */
        public DesignHashMapSolution()
        {
            this.map = new int[1000000];
            for (int i = 0; i < 1000000; i++)
            {
                this.map[i] = -1;
            }
        }

        /** value will always be positive. */
        public void put(int key, int value)
        {
            this.map[key] = value;
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int get(int key)
        {
            return this.map[key];
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void remove(int key)
        {
            this.map[key] = -1;
        }
    }

    /**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.put(key,value);
 * int param_2 = obj.get(key);
 * obj.remove(key);
 */
}