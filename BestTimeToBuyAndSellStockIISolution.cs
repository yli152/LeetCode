using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class BestTimeToBuyAndSellStockIISolution
    {
        //Greedy Algorithm (!difference with DP) 最优解覆盖之前的所有位上的最优解，只有当前最优解，局部最优解累加最为最后最优解
        public int MaxProfit(int[] prices) {
            int len = prices.Length;
            if (len == 0 || len == 1)
            {
                return 0;
            }

            int max = 0;

            for (int i = 0; i < len - 1; i++) {
                if (prices[i + 1] > prices[i]) {
                    max += prices[i + 1] - prices[i];
                }
            }

            return max;
        }
    }
}
