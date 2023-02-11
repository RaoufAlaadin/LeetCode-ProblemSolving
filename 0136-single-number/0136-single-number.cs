public class Solution {
    public int SingleNumber(int[] nums) {
        
        HashSet<int> hashCheck = new HashSet<int>();


        for ( int i = 0; i < nums.Length; i++)
        {
                 if (hashCheck.Contains(nums[i])) 
                        hashCheck.Remove(nums[i]);    
                else
                        hashCheck.Add(nums[i]);    
        }

           for ( int i = 0; i < nums.Length; i++)
        {
                 if (hashCheck.Contains(nums[i])) 
                        return nums[i];
        }
        

        return 0;
    }
}


/* Note: 
    The more effient solution is by using bit manipulation and XOR
    This will give time O(n) but the space complixity will be O(1)
    which is better than our current solution using the hashset
    which gives a space of O(n)

int result = 0;
        foreach (int num in nums) {
            result ^= num;
        }
        return result;
        
 */