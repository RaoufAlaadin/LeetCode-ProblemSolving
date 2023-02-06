public class Solution {
 public int ThirdMax(int[] nums) {
        // Three variables to store maxiumum three numbers till now.
        long firstMaxNum = long.MinValue;
        long secondMaxNum = long.MinValue;
        long thirdMaxNum = long.MinValue;
        
        for (int i = 0; i < nums.Length; i++ ) {
            // This number is already used once, thus we skip it.
            if (firstMaxNum == nums[i] || secondMaxNum == nums[i] || thirdMaxNum == nums[i]) {
                continue;
            }
            
            // If current number is greater than first maximum,
            // It means that this is the greatest number and first maximum and second max
            // will become the next two greater numbers.
            
            
            /* Think about it like a train, every time the first or secondmax get a new value
                The pass on their older value to the max behind them and so on*/
            if (firstMaxNum <= nums[i]) {
                thirdMaxNum = secondMaxNum;
                secondMaxNum = firstMaxNum;
                firstMaxNum = nums[i];
            }
            // When current number is greater than second maximum,
            // it means that this is the second greatest number.
            else if (secondMaxNum <= nums[i]) {
                thirdMaxNum = secondMaxNum;
                secondMaxNum = nums[i];
            }
            // It is the third greatest number.
            else if (thirdMaxNum <= nums[i]) {
                thirdMaxNum = nums[i];
            }
        }
        
        // If third max was never updated, it means we don't have 3 distinct numbers.
        if (thirdMaxNum == long.MinValue) {
           
            return (int)firstMaxNum;
        }
        
       
        return (int)thirdMaxNum;
    }
}