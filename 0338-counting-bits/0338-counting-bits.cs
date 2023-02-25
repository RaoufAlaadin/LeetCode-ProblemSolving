public class Solution {
    public int[] CountBits(int n) {
        

        int[] bitsArray = new int[n+1];
        
        int onesCounter; 
        int current; 


        
        for(int i = 0; i < bitsArray.Length; i++)
        {
            current = i; 
            onesCounter = 0; 

            while (current > 0)
            {
                if ((current & 1) == 1)
                    onesCounter++;
                current >>= 1; 
            }

            bitsArray[i] = onesCounter;
        }
    
        return bitsArray;

        
    }
}

/* We cannot use (current & 1) only as it returns a number, and in C# we can't implicity cast
    a number to a boolen. 
    That's why we have to do explicit cast by doing the following:
            ((current & 1) == 1)
                    1  == 1  ==> true
     */