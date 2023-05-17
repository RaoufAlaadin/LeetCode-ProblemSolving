public class Solution {
    public bool IsPalindrome(string s) {
        
        
        // Alphanumeric ===> Alphabet or numbers 
        
        // We built our own IsAlphaNumeric() function
        // Instead of using IsDigit() and IsLetter() 
    
        var StartIndex = 0; 
        var EndIndex = s.Length -1 ; 
        
        s = s.ToLower();  // --> Everything to lowerCase. 
        
       while( StartIndex < EndIndex)
       {
               if (!IsAlphaNumeric(s[StartIndex]))
                   StartIndex++; 

               else if (!IsAlphaNumeric(s[EndIndex]))
                   EndIndex--; 

               else{
                        if (s[StartIndex] != s[EndIndex])
                            return false; 

                        StartIndex++;
                        EndIndex--;
               }
         
        }
        
        return true; 

    }
    
    
    public bool IsAlphaNumeric(char x)
    {
        return (x >= 'A' && x <= 'Z') || (x >= 'a' && x <= 'z')  || (x >= '0' && x <= '9');
    }
}





/// Draft 


// Note: 

/*
        1- string to lower case 
        2- remove all non - alphanumeric characters
        
        
*/



// Method-1 ===> BAD, it uses a new string, which uses tons of memory. 

// public class Solution {
//     public bool IsPalindrome(string s) {
        
        
//         // Alphanumeric ===> Alphabet or numbers 
    
//         string GoodString = ""; 
        
//         if ( s == "")
//             return true; 
        
//         string str = s.ToLower(); 
        
//         for(int i = 0; i < str.Length; i++)
//         {
//             if (Char.IsLetterOrDigit(str[i]))
//                 GoodString += str[i];
//         }
        
        
//         var StartIndex = 0; 
//         var EndIndex = GoodString.Length -1 ; 
        
//        while( StartIndex < EndIndex)
//        {
//            if(GoodString[StartIndex] != GoodString[EndIndex])
//                        return false; 
           
//                     StartIndex++;
//                     EndIndex--;

//         }
        
//         return true; 

//     }
// }