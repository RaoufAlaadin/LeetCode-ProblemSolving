public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        
        
        var dict = new Dictionary<int,int>(); 
        
        for(int i = 0; i < arr.Length; i++)
        {
            if( !dict.ContainsKey(arr[i]))
                dict[arr[i]] = 1; 
            else
                dict[arr[i]] ++ ;
        }
        
        // The result we got, is basically like 
        //  An array where we need to find the duplicates. 
        
        // Everytime we need to compare one element from the array
        // With the rest of the array. 
        
        // instead of doing it using 2 for loops (n^2)
        
        // ==> use 1 forloop and a hashset instead for (n) :> 
        
        var TrackSet = new HashSet<int>(); 
        
        foreach ( KeyValuePair<int,int> item in dict )
        {
            Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            
            // if (dict.ContainsValue(item.Value)) --> wrong
            //     return false; 
            
            if (!TrackSet.Contains(item.Value))
                TrackSet.Add(item.Value);
            else
                return false; 
           
        }

    
        
        return true; 
    }
}


/* To check if the each occurance is unique, 
    
    
    1- I need to find the occurance in each element in the array. 
    
    
    2- Store the results in a dictionary maybe.
    
        key -> element value 
        value -> number of occurance 
        
    3- After finishing the array, go over the dictionary 
       and check if the value have been registered before. 
       
     ----------------------------------------------------
     
     Note: 
     
        In ourcase we only need to return true/false. 
        So there wouldn't be a need to occurance values it'self
        (not going to be printed like the other problem.)
        
        So we might use a hashSet and return false immediatly
        If we find a duplicate in our check when we are adding. 
        
        
        BUT!! using a dictionary is better for storing the occurances
        And keep adding to them as we go instead of creating an array for that
        
        So using a dictionary will server many purposes.. 
        
                ==> use dictionary. 
                
                
        -----------------------
        
        But we need to add a hashSet at the end to track
        Duplications, becuase the following case will always be 
        True because ofcourse one of the pairs have that value..
        
        Like we need to check if the value is there but for different key
        
        
    ===================================================
    
         The result we got After filling the dictionary,
         Is basically like 
            
           ===> An array where we need to find the duplicates. 
        
         Everytime we need to compare one element from the array
         With the rest of the array. 
        
         instead of doing it using 2 for loops (n^2)
        
                ==> use 1 forloop and a hashset instead for (n) :> 
                
                But here we use a foreach as dictionary objects
                Are: 
                
                    1- unordered
                    2- do not have a specific index to access them. 
         
                ==> basically, unordered collection of key-value pairs
                
                    a Dictionary, which is a hash-map Datastructure..
                    Applies the `IEnumerable` interface..
    
                    Which allows the use of the foreach with it.
                    
                    
                    
                    
        IEnumerable:
            1- inherites from IEnumerator that has the .GetEnumerator() method 
            2- All the collections inherites from it so you enumrate over them
                Using foreach. 
                
        IEnumerator: 
            1- Use when you want to specifiy a custom way of iteration.
                Like skipping some elements and so on. 
            
                using the methods given to you by the non-Genric IEnumerator 
                That is returned from --- >  .GetEnumerator()
                
                These methods include: 
                        
                        a- Current
                        b- MoveNext()
                        c- Reset
                
    
    
    
    -------------------------------------------------------------------------------------------------
    
    // Example 1: Using IEnumerable to define a collection that can be enumerated

            // Define a custom collection class that implements IEnumerable
            public class MyCollection : IEnumerable
            {
                private int[] data = new int[] { 1, 2, 3, 4 };

                // Implement the GetEnumerator method
                public IEnumerator GetEnumerator()
                {
                    return data.GetEnumerator();
                }
            }

            // Use the custom collection class with a foreach loop
            MyCollection collection = new MyCollection();
            foreach (int number in collection)
            {
                Console.WriteLine(number);
            }
                
             ===================================
             
    // Example 2: Using IEnumerator to manually iterate through a collection

            // Create a simple collection
            int[] numbers = new int[] { 1, 2, 3, 4 };

            // Get an enumerator for the collection
            IEnumerator enumerator = numbers.GetEnumerator();

            // Use the enumerator to iterate through the collection
            while (enumerator.MoveNext())
            {
                // Access the current element
                int currentNumber = (int)enumerator.Current;

                // Do something with the current element
                Console.WriteLine(currentNumber);
            }
     ---------------------------------------------               
                    
                     public interface IEnumerator
    {
        // Interfaces are not serializable
        // Advances the enumerator to the next element of the enumeration and
        // returns a boolean indicating whether an element is available. Upon
        // creation, an enumerator is conceptually positioned before the first
        // element of the enumeration, and the first call to MoveNext 
        // brings the first element of the enumeration into view.
        // 
        bool MoveNext();
    
        // Returns the current element of the enumeration. The returned value is
        // undefined before the first call to MoveNext and following a
        // call to MoveNext that returned false. Multiple calls to
        // GetCurrent with no intervening calls to MoveNext 
        // will return the same object.
        // 
        Object Current {
            get; 
        }
    
        // Resets the enumerator to the beginning of the enumeration, starting over.
        // The preferred behavior for Reset is to return the exact same enumeration.
        // This means if you modify the underlying collection then call Reset, your
        // IEnumerator will be invalid, just as it would have been if you had called
        // MoveNext or Current.
        //
        void Reset();
    }
    
    
    -------------------------------------------------------
                     public interface IEnumerator<out T> : IDisposable, IEnumerator
                    {    
                        // Returns the current element of the enumeration. The returned value is
                        // undefined before the first call to MoveNext and following a
                        // call to MoveNext that returned false. Multiple calls to
                        // GetCurrent with no intervening calls to MoveNext 
                        // will return the same object.
                        // 
                        /// <include file='doc\IEnumerator.uex' path='docs/doc[@for="IEnumerator.Current"]/*' />
                        new T Current {
                            get; 
                        }
                    }
                    
                    ----------------------

                                  public interface IEnumerable<out T> : IEnumerable
                {
                    // Returns an IEnumerator for this enumerable Object.  The enumerator provides
                    // a simple way to access all the contents of a collection.
                    /// <include file='doc\IEnumerable.uex'                                                  path='docs/doc[@for="IEnumerable.GetEnumerator"]/*' />
                    new IEnumerator<T> GetEnumerator();
                }
    
    
    
    */