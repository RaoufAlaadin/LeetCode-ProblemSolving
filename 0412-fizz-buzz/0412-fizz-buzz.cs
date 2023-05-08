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












// All the possible solutions will still result in 
// // TC: O(n), SC: O(n)   ::: Time complexity : SpaceComplixity

// No % 

// class Solution {
//     public List<String> fizzBuzz(int n) {
//         List<String> res = new ArrayList<>();
//         int i = 1, fizz = 0, buzz = 0;
//         while (i <= n){
//             fizz++; buzz++;
//             if (fizz == 3 && buzz == 5) {
//                 res.add("FizzBuzz");
//                 fizz = buzz = 0;
//             } else if (fizz == 3) {
//                 res.add("Fizz");
//                 fizz = 0;
//             } else if (buzz == 5) {
//                 res.add("Buzz");
//                 buzz = 0;
//             } else {
//                 res.add(String.valueOf(i));
//             }
//             i++;
//         }

//         return res;
//     }
// }


// Ternary

// class Solution {
//     public List fizzBuzz(int n) {
//         List ans = new ArrayList<>();
//         for(int i = 1; i <= n; i++){
//             ans.add(
//                 i % 15 == 0 ? "FizzBuzz" :
//                 i % 5 == 0  ? "Buzz" :
//                 i % 3 == 0  ? "Fizz" :
//                 String.valueOf(i)
//             );
//         }

//         return ans;
//     }
// }