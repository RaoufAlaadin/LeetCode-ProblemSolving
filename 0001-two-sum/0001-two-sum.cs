// public class Solution {
//     public int[] TwoSum(int[] nums, int target) {
        
//         // int[] result = new int[2];  
        
//         var result = new List<int>(); 
        
//         var numsDictionary = new Dictionary<int,int>(); 
        
//         for(int i = 0; i < nums.Length ; i++)
//         {
//             var elementComplement = target - nums[i]; 
//             if (numsDictionary.ContainsKey(elementComplement))
//             {
//                 result.Add(i); 
                
//                 //TryGetValue is safer than Indexer. 
//                 // Indexer throws -> KeyNotFoundException
//                 // While TryGetValue returns true/false boolen responce.
//                 numsDictionary.TryGetValue(elementComplement,out int index);
                
//                 result.Add(index);
                
//                 return result.ToArray(); 

//             }
//             else{
//                if (!numsDictionary.ContainsKey(nums[i])) {
//                     numsDictionary.Add(nums[i], i);
//                 }
//             }
//         }
        
//         return null;
        
//     }
// }









/* Very Important 

    as long as we need both the Element's indecies and values 
    
    You have to use a Dictionary. !!
    
    As using a HashSet for this case will lead us to use 
    
        ---> indexof() to get the element indecies from 
             The original nums array.
             
             this takes O(n) ( like a forloop).
             
             And being already in a for loop makes the resulting 
             Time complexity to be --> O(n^2) .. which is bad --x 
    


[1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1]
11

*/




public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        // int[] result = new int[2];  
        
        var result = new List<int>(); 
        
        var numsSet = new HashSet<int>(); 
        
        for(int i = 0; i < nums.Length ; i++)
        {
            var elementComplement = target - nums[i]; 
            if (numsSet.Contains(elementComplement))
            {
                result.Add(i); 
                result.Add(Array.IndexOf(nums,elementComplement));
                
                return result.ToArray(); 

            }
            else{
                numsSet.Add(nums[i]);
            }
        }
        
        return null;
        
    }
}


//draft 

/*
        1- one solution per input 
        2- same element cannot be used twice ! 
        
            ex: I think they mean
            
    --> We are returning the `indecies` of the 
        Element which sum gave us our target. 

*/

/*
    Time and Space complixities. 
    
    O(n^2)
    O(nlog(n)) --> Sorting 
    O(n) --> for loop 
    O(log(n)) --> binary search 
    O(1) --> Constant --> HashSet
    

*/

/*

    When using a dictionary

            --> Set the ket
    HashSet is basically 
            -> a List that prevents duplicates (Everything is unique.)
    
       Some of the most commonly used methods for `HashSet` are:
       
       
        - `Add`: Adds an element to the `HashSet`.
        - `Remove`: Removes an element from the `HashSet`.
        - `Contains`: Determines whether the `HashSet` contains a specific element.
        - `Clear`: Removes all elements from the `HashSet`.
        - `UnionWith`: Modifies the current `HashSet` to contain all elements that are present in itself or             in the specified collection.

Some of the most commonly used methods for `Dictionary` are:

        - `Add`: Adds a key/value pair to the `Dictionary`.
        - `Remove`: Removes a key/value pair from the `Dictionary`.
        - `ContainsKey`: Determines whether the `Dictionary` contains a specific key.
        - `TryGetValue`: Gets the value associated with a specific key.
        - `Clear`: Removes all key/value pairs from the `Dictionary`.



        // HashSet example
        HashSet<int> set = new HashSet<int>();
        set.Add(1);
        set.Add(2);
        set.Add(3);
        set.Add(4);
        set.Add(5);

        Console.WriteLine("HashSet contains 3: " + set.Contains(3)); // True
        Console.WriteLine("HashSet contains 6: " + set.Contains(6)); // False

        // Dictionary example
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary.Add("apple", 1);
        dictionary.Add("banana", 2);
        dictionary.Add("cherry", 3);

        Console.WriteLine("Value of key 'banana': " + dictionary["banana"]); // 2
        
        
        ContainsValue --->

                Dictionary<string, int> dictionary = new Dictionary<string, int>();
                dictionary.Add("apple", 1);
                dictionary.Add("banana", 2);
                dictionary.Add("cherry", 3);

                bool hasOne = dictionary.ContainsValue(1); // true
                bool hasFour = dictionary.ContainsValue(4); // false
        

        TryGetValue --->

                Dictionary<string, int> dictionary = new Dictionary<string, int>();
                dictionary.Add("apple", 1);
                dictionary.Add("banana", 2);
                dictionary.Add("cherry", 3);

                int value;
                bool hasApple = dictionary.TryGetValue("apple", out value); // true, value = 1
                bool hasMango = dictionary.TryGetValue("mango", out value); // false

*/
