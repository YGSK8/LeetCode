namespace SlidingWindow;

public class SlidingWindow
{
    public static int MaxProfit(int[] prices)
    {
        int left = 0;//-buy
        int right = prices.Length-1;//sell
        int profit = prices[right]-prices[left];
        int low=0;
        int high=0;
        while (left < right)
        {
               int leftProfit = prices[right]-prices[left+1];//--should have bought the next day
               int rightProfit = prices[right-1]-prices[left];//--should have sold the previous day
               if(leftProfit==rightProfit)left++;//--last loop always hits this one since same element will be compared and will always be 0. Also allows while loop to exit.
               else if (leftProfit > rightProfit)
                {
                    if(leftProfit>profit){profit=leftProfit;low=left+1;high=right;}
                    left++;
                }
                else if (rightProfit > leftProfit)
                {
                    if(rightProfit>profit){profit=rightProfit;low=left;high=right-1;}
                    right--;
                }
        }
        if(profit<0)profit=0;
        Console.WriteLine(profit);
        return profit;
    }

    public static int MaxProfitCorrect(int[] prices)
    {
        int minPrice = prices[0];
        int MaxProfit = 0;
        for(int day = 0; day < prices.Length-1; day++)
        {
            if(prices[day]<minPrice)minPrice=prices[day];
            int profit = prices[day+1]-minPrice;
            if(profit>MaxProfit)MaxProfit = profit;
        }
        Console.WriteLine(MaxProfit);
        return MaxProfit;
    }
}