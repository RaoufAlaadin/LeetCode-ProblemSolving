public class Solution {
    public int MaxProfit(int[] prices) {
        
        int BuyPrice = Int32.MaxValue; // To register first element. 
        int MaxProfit = 0; 
        
        for(int i = 0; i < prices.Length ; i++)
        {
            if(prices[i] < BuyPrice)
                BuyPrice = prices[i];
            else if(MaxProfit < prices[i] - BuyPrice){
                MaxProfit = prices[i] - BuyPrice; 
            }
            
            
        }
            
       return MaxProfit;  
        
    }
}



