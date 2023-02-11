public class Solution {
    public int MissingNumber(int[] nums) {
        
        int sumCorrect= 0; 
        int sumFalse = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            sumCorrect += i;
            sumFalse += nums[i];  
        }
        

        
        
        return sumCorrect + nums.Length - sumFalse; 
        
       
    }
}


    // Method-2
//  HashSet<int> hashCheck = new HashSet<int>();
//         int max = nums[0];

//         for ( int i = 0; i < nums.Length; i++){
//            hashCheck.Add(nums[i]);
//         }
        

//         for ( int i = 0; i < nums.Length+1; i++){
//                 if(!hashCheck.Contains(i)) 
//                 return i;
//         }
        
//         return 0;