namespace LT150;

// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/?envType=study-plan-v2&envId=top-interview-150

public static class StockBuySell1
{
    public static int MaxProfit(int[] prices)
    {
        if (prices == null || !prices.Any() || prices.Length < 2)
            return 0;

        int profit = 0, buy = 0, sell = 1, currentProfit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] <= prices[buy])
            {
                buy = i;
                if (buy > sell)
                    sell = buy;
            }

            if (prices[i] >= prices[sell])
                sell = i;

            if (sell > buy)
            {
                currentProfit = prices[sell] - prices[buy];
                profit = Math.Max(profit, currentProfit);
            }
        }

        if (sell > buy)
            profit = prices[sell] - prices[buy];

        return profit > 0 ? profit : 0;
    }
}