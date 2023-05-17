public class Solution {
    public bool IsAnagram(string s, string t) {
        
        
        var DictRight = new Dictionary<char,int>();
        var DictLeft = new Dictionary<char,int>();

        
        if (s.Length != t.Length)
            return false; 
        
        for (int i = 0; i < s.Length; i++)
        {
            if(DictRight.ContainsKey(s[i]))
                DictRight[s[i]]++; 
            else
                DictRight[s[i]] = 1; 
            
            if(DictLeft.ContainsKey(t[i]))
                DictLeft[t[i]]++; 
            else
                DictLeft[t[i]] = 1; 
                
                
        }
        
        
        foreach(KeyValuePair<char,int> item in DictRight)
        {
            if(!DictLeft.ContainsKey(item.Key))
                return false; 
            
            if(DictLeft[item.Key] != item.Value)
                return false; 
        }
        
        return true; 
    }
}





/// Draft 

/*
   -- We need a 2x dictionary,
                
                key --> char 
                value --> number of occurance 
                
    -- We do it for both and compare
        if a char is not inside the dict, we just return false immediatly. 
        

        xxxxx Bad ==> if we Store one of the words in a HashSet. ---> No xxx bad !!! 
        
 

        
        

*/