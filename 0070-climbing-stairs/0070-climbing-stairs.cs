public class Solution {
    public int ClimbStairs(int n) {
     
        // We will use the dynamic programming method
        
        
        // We could have also used fibonacci-sequence => 1,2,3,5,8,13... 
        // as it's basically the same pattern. 
        
        
        if (n <= 2) return n;
    int[] dp = new int[n + 1];
    dp[0] = 0;
    dp[1] = 1;
    dp[2] = 2;
    for (int i = 3; i <= n; i++) {
        dp[i] = dp[i - 1] + dp[i - 2];
    }
    return dp[n];
    }
}