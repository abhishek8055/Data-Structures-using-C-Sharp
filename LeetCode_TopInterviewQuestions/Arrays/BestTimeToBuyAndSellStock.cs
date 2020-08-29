namespace DATASTRUCTURES.LeetCode_TopInterviewQuestions.Arrays
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    maxProfit += prices[i] - prices[i - 1];
            }
            return maxProfit;
        }
        public static void MainMethod()
        {
            int[] prices = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            BestTimeToBuyAndSellStock obj = new BestTimeToBuyAndSellStock();
            int x = obj.MaxProfit(prices);
        }
    }
}