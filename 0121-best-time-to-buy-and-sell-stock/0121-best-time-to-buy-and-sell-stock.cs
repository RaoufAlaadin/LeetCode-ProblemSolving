public class Solution {
    public int MaxProfit(int[] prices) {

        //1- using int.MaxValue ensures that our first condition is met
        // and that we will get a minValue from the array itself.
        // Value = 2147483647

       int minPrice = int.MaxValue;
       
       // 2- if the second if condition is never met, then the array is sorted in Desc
       // and maxProfit will be unchanged and returned as 0
        int maxProfit = 0; 

        for (int i = 0; i < prices.Length; i++) {

            // 3- if we find a new min we update. 
            if (prices[i] < minPrice) {
                minPrice = prices[i];
            } 

            // 4- this is the condition we use the most,
            // if the difference between our current element and the min we currently use
            // is bigger than current maxProfit, then we Update our maxProfit. 

            else if (prices[i] - minPrice > maxProfit) {
                maxProfit = prices[i] - minPrice;
            }
        }

        return maxProfit;
    }



}