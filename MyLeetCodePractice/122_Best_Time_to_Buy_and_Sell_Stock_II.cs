using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCodePractice
{
    class _122_Best_Time_to_Buy_and_Sell_Stock_II
    {
        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    profit += prices[i + 1] - prices[i];
                }

            }
            Console.WriteLine(profit);
            return profit;
        }
    }
}
