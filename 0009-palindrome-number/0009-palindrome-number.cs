public class Solution {
    public bool IsPalindrome(int x) {
        
        
        var StartIndex = 0; 
        var EndIndex = x;
            
        var OriginalNumber = x ; 
        var ReversedNumber = 0; 
        
        
        if (OriginalNumber < 0)
            return false; //--> negative is always not a palindrom.
        
        while ( x != 0 )
        {
            var Temp = x % 10 ; 
            ReversedNumber = ReversedNumber * 10 + Temp; 
            
            x /= 10; 
        }
        
        // if(OriginalNumber != ReversedNumber)
        //     return false; 
        // else
        //     return true; 
        
        return OriginalNumber == ReversedNumber; //--> Smarter. 
        
    }
}


/// Draft 

/* 
    We just need to reverse the number 
    
    %10 --> gives you the last number on the right 
    
    /10 --> removes that number, so you can get the next one 
            In the next loop 
            
            ReversedNumber = Reversed * 10 + that right digit 

*/