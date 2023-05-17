public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        

        var DuplicateTrackerSet = new HashSet<int>(); 
        
        for(int i = 0; i < nums.Length; i++)
        {
            if (DuplicateTrackerSet.Contains(nums[i]))
            {
                return true; 
            }
            else 
                DuplicateTrackerSet.Add(nums[i]);
        }
        
        return false; 
        
    }
    
    
}


/// Draft 

/*
            -Time comlixity: O(n)
                As we fill the hash set using the same for loop we are checking by
                and accessing those elements using contains() is O(1) as hashing made us 
                know the exact spot of the element
                
            -Space complixty: O(n)
                
                Took more space due to the hashing which declares a new element every iteration
                   


         // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1?view=net-7.0

*/