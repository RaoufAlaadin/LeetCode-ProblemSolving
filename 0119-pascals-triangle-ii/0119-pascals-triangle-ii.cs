public class Solution {
    public IList<int> GetRow(int rowIndex) {
        
        //1-Create a List the hold lists, Where each list is
        // going to be a row. 
        
        List<List<int>> Triangle = new List<List<int>>();
        List<int> PreviousRow = new List<int>();

       
        int sum = 0; 
        
        if (rowIndex == 0) return new List<int>(){1};
     
        Triangle.Add(new List<int>(){1});  // index = 0
        
        
        int TargetRowLength = rowIndex + 1 ; // assumed line 2 if it passes the above.
        
        PreviousRow = new List<int>(){1,1};
        
    for( int i = 1; i < TargetRowLength; i++)
    {
       List<int> CurrentRow = new List<int>();

        
        //2- this will always update our previous row. 
        
        // *****Important Note*****
        
        // Java has list.get() ...
        // but C# can use the index normally to get data,
        // because We have indexers. 
        
        PreviousRow = Triangle[i-1];
        //3- by knowing that all rows will start with 1 and ends with 1 
        // so we add a 1 and loop for the numbers in-between and then add a 1 again
        // to end our list 
        
        CurrentRow.Add(1); 
        
        //4- we start at 1 because we already added a (1) at the start of 
        // the List, And We will loop to (i) which is the row number,why not (i+1)?
        // because we want don't want to calcualte the last element
        
        //Note: Trying to calculate the first or last element using our method 
        //      Will result in ===> indexOutOfRangeExceptionError. 
        
        // Ex: for row 1 ===> i = 1
        // so  J<i is false , and we skip the loop, but we added 1 before and 
        // after the loop.... ==> which what we wanted. 
        
        for (int j = 1; j <i; j++)
        {
            sum = PreviousRow[j-1] + PreviousRow[j];
            CurrentRow.Add(sum);
        }
        
        CurrentRow.Add(1);
        Triangle.Add(CurrentRow);
        
        // NOTE: DO NOT USE clear() or anything similar
        // The problem is that we passed the CurrentRow to the triangle (by reference)
        // So the triangle and CurrentRow are referencing the same Object
        // That's why using Clear will empty the object that triangle needed
        
        // That's why we need to create a new CustomerRow object everytime
        // or look for a work around for passing by value which is the following => 

        //1- this creates a new object and copies the CurrentRow values
        
        // Triangle.Add(new List<int>(CurrentRow)); 
        
        //2- now like this, the CurrentRow Object will be
        //the same during the whole progam... we clear it.. add new values
        // and so on. 
        
        
        // CurrentRow.Clear(); 
        
    }

        
        return Triangle[rowIndex];
        
    }
}