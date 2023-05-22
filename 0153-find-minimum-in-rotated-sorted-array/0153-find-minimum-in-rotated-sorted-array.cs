public class Solution {
    public int FindMin(int[] nums) {
        
        if(nums.Length == 1)
            return nums[0];
       
        var Left = 0; 
        var Right = nums.Length -1 ; 
        
        while ( Left <= Right)
        {
            var Middle = (Right - Left)/ 2  + Left ; 
            
            
            if ( nums[Middle]  > nums[Middle + 1])
                return nums[Middle + 1]; // --> min number
            else if (nums[Right] < nums[Middle])
                Left = Middle ; 
            else if (nums[Left] > nums[Middle])
                Right = Middle; 
            else
                return nums[0];
        }
        
        return nums[0];
    }
}



/// Draft 

/*

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