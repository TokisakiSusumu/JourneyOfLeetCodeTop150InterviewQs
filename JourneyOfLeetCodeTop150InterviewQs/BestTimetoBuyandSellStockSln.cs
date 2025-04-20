namespace JourneyOfLeetCodeTop150InterviewQs;
public class BestTimetoBuyandSellStockSln
{
    public int MaxProfit(int[] prices)
    {
        int maxProf = 0, buy = prices[0];
        for (int i = 1; i < prices.Length; i++) 
        {
            if (prices[i] - buy < 0) 
            {
                buy = prices[i];
            }
            else
            {
                maxProf = Math.Max(maxProf, prices[i] - buy);
            }
        }
        return maxProf;
    }

    public int MaxProfitII(int[] prices)
    {
        //I can do infinite times, basically, once make profit then sell
        //but now, will there be a case that
        //it would be better to sell it next time?
        //well the answer is we can do it greedy, bascially.
        //if it is like 1, 5, 100, then we will get the same result 99 no matter if we sell when it is 1 or 5
        //which means we can just sell it when we can get profit
        //1, 5, 3, 100
        //consider this case, we would still benefit more when we do the same thing previously basically only buy when low
        int prof = 0, buy = prices[0];
        for (int i = 1; i < prices.Length; i++)
        {
            //if we can make profit, sell it
            if (prices[i] - buy > 0)
            {
                prof += prices[i] - buy;
            }
            buy = prices[i];
        }
        return prof;
    }
}
