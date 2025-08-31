namespace ProblemSolving.LeetCode.Array_String
{
    public class BestTimeBuySellStock121
    {
        //https://leetcode.com/problems/best-time-to-buy-and-sell-stock
        public int MaxProfit(int[] prices)
        {
            int min = prices[0], peak = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > min)
                {
                    int possiblePeak = prices[i] - min;
                    if (possiblePeak > peak)
                        peak = possiblePeak;
                }
                else
                {
                    min = prices[i];
                }
            }
            return peak;
        }

        private int Solution3(int[] prices)
        {
            //  after investigation, i didn't really need max, since i am always moving forward i don't need to worry about 
            //  previous peaks as i am only concerned by next selling price and if it would make profit and if the profit is higher than max
            //  this saves some memory and some operations enhancing overall performance
            int min = prices[0], peak = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > min)
                {
                    int possiblePeak = prices[i] - min;
                    if (possiblePeak > peak)
                        peak = possiblePeak;
                }
                if (prices[i] < min)
                {
                    min = prices[i];
                }
            }
            return peak;
        }

        private int Solution2(int[] prices)
        {
            //  the idea was to assume a peak at the start then test for more peaks, if a higher peak appears i only need to keep the peak value
            //  this seems a good solution time of O(n) and space of O(1) 
            //  but when run on leetcode there are much better time and space performances
            //  so lets try more for better
            int min = prices[0], max = prices[0], peak = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > max && prices[i] > min)
                {
                    int possiblePeak = prices[i] - min;
                    if (possiblePeak > peak)
                        peak = possiblePeak;
                }
                if (prices[i] < min)
                {
                    min = prices[i];
                    max = 0;
                }
            }
            return peak;
        }

        private int Solution1(int[] prices)
        {
            //  this solution works but very slow due to nested loop making time complexity O(N^2)
            //  need to find better solution
            int peak = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int profit = prices[j] - prices[i];
                    if (profit > peak)
                    {
                        peak = profit;
                    }
                }
            }
            return peak;
        }

    }
}
