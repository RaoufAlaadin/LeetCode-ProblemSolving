public class Solution {
    public bool IsValid(string s) {
        
        
        // not even --> s = "]"
        
        if(s.Length % 2 != 0)
            return false; 
        
        
        var MyStack = new Stack<Char>();
        
        for(int i = 0; i < s.Length; i++ )
        {
            if(s[i] == '{'|| s[i] == '('|| s[i] == '[' )
                MyStack.Push(s[i]);
            else if(s[i] == '}' && MyStack.Count != 0 && MyStack.Peek() == '{' )
                MyStack.Pop(); 
            else if(s[i] == ']' && MyStack.Count != 0 && MyStack.Peek() == '['  )
                MyStack.Pop(); 
            else if(s[i] == ')' && MyStack.Count != 0 &&  MyStack.Peek() == '(' )
                MyStack.Pop(); 
            else{
                return false;
            }
        }
        
        return MyStack.Count == 0;
    }
}



/// Draft

// We should be using a stack 


/*
   

    - Use .Count stack property instead of .Count() LinQ


   Why Stack ?! 

        -I think it's moslty used to place the element
         Under-supervision, for quick comparsion with 
         Our next element.
        -It allows us to remove the last element we inserted,
         Without really caring what is it exactly. 
        
   A stack means 
   Last-in-First-Out 
   
   
   Input
"([}}])"
Output
true
Expected
false


*/