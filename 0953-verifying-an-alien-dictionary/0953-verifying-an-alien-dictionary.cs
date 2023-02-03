public class Solution {
   public  bool IsAlienSorted(string[] words, string order)
        {

            for (int i = 0; i < words.Length - 1; i++)
            {

                // 1- this part takes the smaller word to not get index out of range when comparing
                int comparisonLength = words[i + 1].Length;
                if (words[i].Length < words[i + 1].Length)
                    comparisonLength = words[i].Length;

                
                // 2- this flag makes sure that if we already found that the 2 words matches
                // the return false won't be activated if it's condition was true in later characters.

                bool sorted = false;

                for (int j = 0; j < comparisonLength; j++)
                {
                    // 3- if we find that the 2 words are sorted, we raise the flag to 
                    // not do anything else until the cycle    
                    if (order.IndexOf(words[i][j]) < order.IndexOf(words[i + 1][j]))
                       sorted = true; 
                    // 4- if we found atleast one mismatched character, so the whole array is not sorted
                    // and we end our code.
                    else if (order.IndexOf(words[i][j]) > order.IndexOf(words[i + 1][j]) && sorted == false)
                        return false; 
               
                }

               
                // 5- this handles if nothing happend in the comparison, then this means
                // that the part we compared is a a complete match, same charachters and same order
                // so based on the 3rd example, if the longer word is first, then the array is not sorted.
                
                // BUT !!! ==> we have to keep in mind in to add the condtion that sorted == false
                // as something like the following ===> "asdas", "a" is sorted and it was caught in our
                // charachter by charachter comparison. 
                if (words[i].Length > words[i + 1].Length && sorted == false)
                return false;

            }

            return true;
        }
}