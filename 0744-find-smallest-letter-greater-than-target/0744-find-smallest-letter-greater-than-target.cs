public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        
        // for ( int i = 0; i < letters.Length; i++)
        // {
        //     if ( letters[i] > target)
        //         return letters[i];
        // }

        // return letters[0];

        if (letters[letters.Length-1] < target)
            return letters[0];


        int min = 0 ; 
    int max = letters.Length -1; 
    int mid = (max + min )/2;
    char result = letters[0];
    

    while (min <= max)
    {
        mid = (max + min) /2; 

        if( letters[mid] == target)
        {
            min = mid + 1;
        }
        else if ( letters[mid] > target)
        {   
            /* if we ever go into this condition, then for sure we have elemeents
            that satisfy our problems and the solution won't be letters[0]
             */
            // we keep saving the possible result, while moving forward.

            /* saving the mid makes sense if you think about it at the end and we have 
                3 characters, if the target is on the left, we would want the midlle char as
                it's bigger in value
            */ 
            result = letters[mid];
            max = mid - 1; 
        }
        else if ( letters[mid] < target)
        {
            min = mid + 1; 
        }

    }

    return result;
        
    }

    




}





