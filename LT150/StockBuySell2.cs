namespace LT150;

// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/submissions/1167706978/?envType=study-plan-v2&envId=top-interview-150

public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        bool sold = false;
        int buy = 0, sell = -1;
        for(int i = 1; i < prices.Length;i++)
        {
            if(prices[i] < prices[i-1])
            {
                sold = false;
                //transact
                buy = i;
                //i++;
            }
            else if(prices[i] == prices[i-1])
            {
                if(buy == -1)
                    buy = i;
                    else
                    
                continue;
            }
            else
            {
                sold = false;
                while(i < prices.Length && prices[i] > prices[i-1])
                i++;
                i--;
                sell = i;
            }
            if(buy != -1 && sell != -1 && buy <= sell)
            {
                profit+= prices[sell] -prices[buy];

                sell = buy = -1;
                sold = true;
            }
        }
        return profit;
    }
}