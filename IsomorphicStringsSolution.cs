using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class IsomorphicStringsSolution
    {
        //分情况当前s 1. map中key有了，看相应的t是不是等于现在的t，如果不相等错 2. map中key没有，看map中value有没有t，如果有错
        public bool IsIsomorphic(string s, string t) {
            //int len = s.Length;
            //Dictionary<int, bool> dcs = new Dictionary<int, bool>();

            //for (int i = 0; i < len - 1; i++) {
            //    if (s[i] != s[i + 1])
            //    {
            //        dcs[i] = false;
            //    }
            //    else {
            //        dcs[i] = true;
            //    }
            //}

            //for (int i = 0; i < len - 1; i++)
            //{
            //    if (t[i] != t[i + 1] && dcs[i] == true)
            //    {
            //        return false;
            //    }
            //    if (t[i] == t[i + 1] && dcs[i] == false)
            //    {
            //        return false;
            //    }
            //}

            //if (s.Contains('&') || t.Contains('&')) {
            //    return false;
            //}

            //return true;
            int len = s.Length;
            Dictionary<char, char> dc = new Dictionary<char, char>();

            for (int i = 0; i < len; i++) {
                if (dc.ContainsKey(s[i]))
                {
                    if (t[i] != dc[s[i]]) {
                        return false;
                    }
                }
                else {
                    if (dc.ContainsValue(t[i])) {
                        return false;
                    } 
                    dc[s[i]] = t[i];
                }
            }

            return true;
        }
    }
}
