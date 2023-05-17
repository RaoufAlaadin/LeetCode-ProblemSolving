public class Solution {
    public bool IsAnagram(string s, string t) {
        
        
        // number of letters in alphabet
        // Arrays and the use of alphabet ASCII code ---> (VeryImportant, Used alot) 
        int[] CountOccuranceArray = new int[26]; 

        
        if (s.Length != t.Length)
            return false; 
        
        for (int i = 0; i < s.Length; i++)
        {
                CountOccuranceArray[s[i] - 'a']++; 
                CountOccuranceArray[t[i] - 'a']--; 
        }
        
        
        for( int i = 0; i < CountOccuranceArray.Length; i++)
        {
            if (CountOccuranceArray[i] != 0)
                return false; 
        }
        
        return true; 
    }
}


// a Dictionary would be a hassle, Because you need to check 
// if the key exists or not before increaseing/decreasing. 



/// Draft 

/*
    
    -- Use only one Dictionary or an Array, 
        Keep ++ / -- based on how many occurance is found 
        
            ---> if the final output is 0 occurance for each `letter`
                Then both strings equalized the occurances perfectly 
                
                So... it's an Anagram !! 
                


   -- We need a 2x dictionary,   ====> BAD !!!! 
                 
                key --> char 
                value --> number of occurance 
                
        - We do it for both and compare
        if a char is not inside the dict, we just return false immediatly. 
        

    -- xxxxx Bad ==> if we Store one of the words in a HashSet. ---> No xxx bad !!! 
        
 

        
        

*/



// Method -1  ---> bad for space 


// public class Solution {
//     public bool IsAnagram(string s, string t) {
        
        
//         var DictRight = new Dictionary<char,int>();
//         var DictLeft = new Dictionary<char,int>();

        
//         if (s.Length != t.Length)
//             return false; 
        
//         for (int i = 0; i < s.Length; i++)
//         {
//             if(DictRight.ContainsKey(s[i]))
//                 DictRight[s[i]]++; 
//             else
//                 DictRight[s[i]] = 1; 
            
//             if(DictLeft.ContainsKey(t[i]))
//                 DictLeft[t[i]]++; 
//             else
//                 DictLeft[t[i]] = 1; 
                
                
//         }
        
        
//         foreach(KeyValuePair<char,int> item in DictRight)
//         {
//             if(!DictLeft.ContainsKey(item.Key))
//                 return false; 
            
//             if(DictLeft[item.Key] != item.Value)
//                 return false; 
//         }
        
//         return true; 
//     }
// }