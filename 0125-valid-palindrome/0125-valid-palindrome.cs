public class Solution {
    public bool IsPalindrome(string s) {
        
        
        // Alphanumeric ===> Alphabet or numbers 
    
        string GoodString = ""; 
        
        if ( s == "")
            return true; 
        
        string str = s.ToLower(); 
        
        for(int i = 0; i < str.Length; i++)
        {
            if (Char.IsLetterOrDigit(str[i]))
                GoodString += str[i];
        }
        
        
        var StartIndex = 0; 
        var EndIndex = GoodString.Length -1 ; 
        
       while( StartIndex < EndIndex)
       {
           if(GoodString[StartIndex] != GoodString[EndIndex])
                       return false; 
           
                    StartIndex++;
                    EndIndex--;

        }
        
        return true; 

    }
}





/// Draft 


/*
        1- string to lower case 
        2- remove all non - alphanumeric characters
        
        
*/