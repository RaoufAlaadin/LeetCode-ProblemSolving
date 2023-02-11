public class NumArray {
    
    int[] nums; 


        /* We have to use the prefix sum for better time complixity when recieving multiple queries 
            as soon as you loop once, the access to the sum will be O(1)
        */
    public NumArray(int[] nums) {

        this.nums = new int[nums.Length];

        this.nums[0] = nums[0]; 
        
        for (int i = 1; i < nums.Length; i++)
        {
            this.nums[i] = this.nums[i-1] + nums[i];
        }
        
    }
    
    public int SumRange(int left, int right) {
        
       if (left > 0)
           return this.nums[right]- this.nums[left-1]; 
       else
           return this.nums[right];

        
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */

/* 
        https://www.youtube.com/watch?v=k5Im14rNUFA&ab_channel=CodewithAlisha  
*/