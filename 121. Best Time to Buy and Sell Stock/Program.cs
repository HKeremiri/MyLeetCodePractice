using System.Diagnostics;
int[] prices = [7, 1, 5, 3, 6, 4];

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