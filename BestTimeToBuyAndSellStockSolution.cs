using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class BestTimeToBuyAndSellStockSolution
    {
        //DP to store current max profits, everytime current prices element compares with previous dp[] element using min()
        public int MaxProfit(int[] prices) {
            int len = prices.Length;
            int[] dp = new int[len];
            if (prices.Length == 0 || prices.Length == 1)
            {
                return 0;
            }
            else
            {
                int min = Math.Min(prices[0], prices[1]);
                dp[0] = 0;
                dp[1] = prices[1] - prices[0];

                for (int i = 2; i < len; i++)
                {
                    dp[i] = prices[i] - min;
                    if (prices[i] < min)
                    {
                        min = prices[i];
                    }
                }

                int result = -1;
                if (dp[1] <= 0)
                {
                    result = 0;
                }
                else
                {
                    result = dp[1];
                }

                for (int j = 0; j < len; j++)
                {
                    if (dp[j] > result)
                    {
                        result = dp[j];
                    }
                }

                return result;
            }
        }
    }
}
