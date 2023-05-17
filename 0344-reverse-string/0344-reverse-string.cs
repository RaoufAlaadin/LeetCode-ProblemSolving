public class Solution {
    public void ReverseString(char[] s) {
        
        
        var StartIndex = 0 ; 
        var EndIndex = s.Length - 1; 
        var Temp = 'x'; 
        
        while(StartIndex < EndIndex)
        {
            Temp = s[StartIndex]; 
            s[StartIndex] = s[EndIndex];
            s[EndIndex] = Temp; 
            
            StartIndex++;
            EndIndex--; 
            
        }
        
        
    }
}



/*

    We would have 2 cases, 
    
    if array length is even -> switch every char 
    
    if it's odd --> the middle element stays in place. 

*/