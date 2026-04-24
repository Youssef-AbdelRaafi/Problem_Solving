int MaximumProfit(int [] prices)
{
    int minPrice = int.MaxValue;
    int maxProfit = 0;

    for (int i = 0; i < prices.Length; i++)
    {
        if (prices[i] < minPrice)
        {
            minPrice = prices[i];
        }

        else
        {
            int profit = prices[i] - minPrice;

            if(profit>maxProfit)
            {
                maxProfit = profit;
            }
        }
    }

    return maxProfit;
}

Console.WriteLine(MaximumProfit([7, 1, 5, 3, 6, 4]));