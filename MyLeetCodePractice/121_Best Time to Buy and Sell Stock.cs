using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCodePractice
{
    class FileName
    {
        public int MaxProfit(int[] prices)
        {

            int profit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[i] < prices[j] && prices[j] - prices[i] > profit)
                    {
                        profit = prices[j] - prices[i];
                    }
                }
            }
            Console.WriteLine(profit);
            return profit;
        }
    }
}
