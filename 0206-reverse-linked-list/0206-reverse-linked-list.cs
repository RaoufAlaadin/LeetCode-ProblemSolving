/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        
        /* Next here is another object from the ListNode class, 
            As we don't user pointers. 
        */
        
        
        ListNode prevNode = null; 
        ListNode nextNode = null; 
        
     while( head != null)
     {
        nextNode = head.next; 
        head.next = prevNode; 
        prevNode = head; 
        head = nextNode; 
     }
        
    return prevNode;
        
    }
}


/*  Explaination 

    null   1    2 
    prev  Head  nextNode

it then becomes like this at the end of the while 

    null   1    2 
         prev  nextNode
                Head
                
    check !!! => while (head != null) ✔
    
      1    2       3 
    prev  Head  nextNode   
    
    ==> this is after the first line in the while that moves
        the nextNode reference.


and at the end it will be like the following 

       4    5       null 
    prev  Head  nextNode 
    
      4    5      null 
          prev   nextNode
                  Head

    check !!! => while (head != null) xxx
    
    note: This why it was useful to make the check before
            moving the nextNode pointer, 
            because if we did not, we would be accessing 
            memory that is not ours
            
            ** this would happen if we were using actual pointers
                like in C/C++ , but here we use references. 
                                                            ***
                
                
*/