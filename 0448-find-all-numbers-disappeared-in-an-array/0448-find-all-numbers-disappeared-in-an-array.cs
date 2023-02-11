public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        
        HashSet<int> hashCheck = new HashSet<int>();
             List<int> dissNums = new List<int>();
        
        //1- We everything we got into the hash
        for ( int i = 0; i < nums.Length; i++)
        {
          hashCheck.Add(nums[i]);
        }
        
        // 2- We go over the hash again and check what it contains
        for ( int i = 1; i <= nums.Length; i++){
                if(!hashCheck.Contains(i)) 
                dissNums.Add(i);
             }
        return dissNums; 
        
    }
}