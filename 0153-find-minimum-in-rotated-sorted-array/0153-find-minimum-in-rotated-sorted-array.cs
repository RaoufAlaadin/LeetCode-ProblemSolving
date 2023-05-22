// public class Solution {
//     public int FindMin(int[] nums) {
        
        
       
//         var Left = 0; 
//         var Right = nums.Length -1 ; 
        
        
       
        
        
        
//         while ( Left < Right)
//         {
//              //This handles 2 cases:
//             // 1- Array has 1 element `=`
//             // 2- Array is completely sorted.
//             if (nums[Left] <= nums[Right])
//                 return nums[Left];
        
//             var Middle = (Right - Left)/ 2  + Left ; 
            
//             if ( nums[Middle]  > nums[Left])
//                     Left = Middle + 1; 
//             else
//                     Right = Middle;
//         }
        
//         return nums[Left];
//     }
// }


public class Solution {
    public int FindMin(int[] nums) {
        // Initialize left and right pointers
        int left = 0, right = nums.Length - 1;

        // Binary Search
        while (left < right) {
            // Calculate mid-point
            int mid = left + (right - left) / 2;

            // If mid-point element is greater than the last element
            // of the array, then the minimum element must be in the
            // right half of the array, so we update left pointer
            if (nums[mid] > nums[right]) {
                left = mid + 1;
            } 
            // Otherwise, the minimum element must be in the left half
            // of the array, so we update right pointer
            else {
                right = mid;
            }
        }

        // At the end of the while loop, left pointer points to the
        // minimum element of the array, which is the answer
        return nums[left];
    }
}



/// Draft 

/*

  if ( nums[Middle]  > nums[Left])
       Left = Middle + 1; 
       
       
    - Here we were able to skip the middle by adding 1 ,
    Because if the first element is less than it, 
    Then the right side have a desending order that will contain
    The Min number. 
    
    This condition just proved that our Middle is not the min number. 



    else
         Right = Middle;
         
    - This condition just keeps squeezing the side we choose,
        To get out of the while and pick the far left in the
        Final sub-array. 


[3,4,5,1,2]

[2,3,4,5,1]
[4,5,1]
[5,1]



        What is Rotating ? 
        
        Imagine we have connected the array's ends
        To form a circle.
        
        If we move an element from the right side,
        It will appear on the left side. 
        
        Each rotation moves a single element. 
  --------------------------------------------------
  
    BinarySearch only works on `sorted` arrays.     ------------> (VeryImportant) 
    
    This is why we need 
        
        [4, 5, 6, 7, 0, 1, 2].
        
        All the elements to the `left` of inflection point > first element of the array.
                   [4, 5, 6, 7].                                [4]
        
        All the elements to the `right` of inflection point < first element of the array.
                   [ 0, 1, 2].                                   [4]        
                   
 -------------------------------------------------------------
 
             var Middle = (Right - Left)/ 2  + Left ; 
             
             Basically, we ge the middle value,
             But if the left is not at `0`, 
             
             Then we specificly need to add the `Left` again 
             For the middle point we got to be a valid positon in the array. 
             
             Ex: 
                     0   1  2 3  4
                    [10,20,30,40,50]
                    
                    for --> [20,30,40]
                    Mid = (3-1)/2 = 1; 
                    
                    But 30's index is not (1) it's (2)
                    That's why we add the Left again,
                    To get the actual position in the array. 
                    


*/



// public class Solution {
//     public int FindMin(int[] nums) {
        
        
       
//         var Left = 0; 
//         var Right = nums.Length -1 ; 
        
        
//         //This handles 2 cases:
//         // 1- Array has 1 element `=`
//         // 2- Array is completely sorted.
//         if (nums[Left] <= nums[Right])
//             return nums[Left];
        
        
        
        
//         while ( Left <= Right)
//         {
//             var Middle = (Right - Left)/ 2  + Left ; 
            
            
//             if ( nums[Middle]  > nums[Middle + 1])
//                 return nums[Middle + 1]; // --> min number
//             else if (nums[Right] < nums[Middle])
//                 Left = Middle ; 
//             else if (nums[Left] > nums[Middle])
//                 Right = Middle; 
//             else
//                 return nums[0];
//         }
        
//         return nums[0];
//     }
// }