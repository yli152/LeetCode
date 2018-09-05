using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Leetcode
{
    public class DistributeCandiesSolution
    {
        public int DistributeCandies(int[] candies) {
            int len = candies.Length;
            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < len; i++) {
                hs.Add(candies[i]);
            }

            return hs.Count >= candies.Length / 2 ? candies.Length / 2 : hs.Count;
        }
    }
}
