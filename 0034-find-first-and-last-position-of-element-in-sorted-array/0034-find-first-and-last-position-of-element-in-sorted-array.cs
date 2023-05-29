public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        
                 
                    // Right --> true 
                    // Left --> false 
                    int CorrectRightIndex = BaisedBinarySearch(nums, target,true);
                    int CorrectLeftIndex = BaisedBinarySearch(nums , target, false);
        
                    // Console.WriteLine(CorrectRightIndex);
                    Console.WriteLine(CorrectLeftIndex);

        
        
                    return new int[]{CorrectLeftIndex,CorrectRightIndex}; 
        
        // return new int[] {-1,-1};
        

    }
        // 0 1 2 3 4 5 
//     [5,7,7,8,8,10]
// 8


private int BaisedBinarySearch(int[] nums, int target, bool baise)
{
    int left = 0;
    int right = nums.Length - 1;
    int index = -1;

    while (left <= right)
    {
        int middle = left + (right - left) / 2;

        if (nums[middle] < target)
            left = middle + 1;
        else if (nums[middle] > target)
            right = middle - 1;
        else
        {
            index = middle;
            if (baise)
                left = middle + 1;
            else
                right = middle - 1;
        }
    }

    return index;
}
   
    
}











// Draft 



/*
        The edit wae made was, 
            Even if we find the target,
            We will shift to the right or the left, 
            To place ourself in a position that would break the loop
            By having the pointers on top of each other. 
            
            
              if( nums[Middle] == Target)
                Left = Middle +1 ;      -------->  both will apply... 
                
            else if (nums[Middle] > Target)
                Right = Middle -1; 
                
            else if (nums[Middle] < Target)
                Left = Middle +1 ;      ----------> ... The same condition.
                
                
                seeing this, we note that the code could be simplified. 
                
                
                if( nums[Middle] >= Target)
                    Left = Middle + 1; 
                    
                else{
                        Right = Middle -1 
                }


            We comfertably used `else` because:
                    we used the other 2 possible comparisons, 
                    Which are `=` and `>` 
                    
                    So the onlything left is `>` 
                
*/


// public class Solution {
//     public int[] SearchRange(int[] nums, int target) {
//         var correctRightIndex = FindRightIndex(nums, target);
//         var correctLeftIndex = FindLeftIndex(nums, target);
//         return new int[] { correctLeftIndex, correctRightIndex };
//     }
    
//     public int FindRightIndex(int[] nums, int target) {
//         var left = 0;
//         var right = nums.Length - 1;
//         var rightIndex = -1;
        
//         while (left <= right) {
//             var middle = (right + left) / 2;
                
//             if (nums[middle] <= target) {
//                 left = middle + 1;
//             } else {
//                 right = middle - 1;
//             }
            
//             if (nums[middle] == target) {
//                 rightIndex = middle;
//             }
//         }
        
//         return rightIndex;
//     }
    
//     public int FindLeftIndex(int[] nums, int target) {
//         var left = 0;
//         var right = nums.Length - 1;
//         var leftIndex = -1;
        
//         while (left <= right) {
//             var middle = (right + left) / 2;
                
//             if (nums[middle] >= target) {
//                 right = middle - 1;
//             } else {
//                 left = middle + 1;
//             }
          
//             if (nums[middle] == target) {
//                 leftIndex = middle;
//             }
//         }
        
//         return leftIndex;
//     }
// }