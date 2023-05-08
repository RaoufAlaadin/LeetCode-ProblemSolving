public class Solution {
    public IList<string> FizzBuzz(int n) {
        
        
        var StringList = new List<string>(); 
        
        for (int i = 1; i < n+1; i++ )
        {
               if (i % 3 == 0 && i % 5 == 0)
             StringList.Add("FizzBuzz");  
            
                else if (i % 3 == 0)
                StringList.Add("Fizz");

            else if (i % 5 == 0)
            StringList.Add("Buzz");    


            
   

            else 
                StringList.Add($"{i}");
                

        }
        
        
        return StringList;
        
        
    }
}