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
        
        ListNode prev=null;
        ListNode Curr=head;
        while(Curr!=null){
            ListNode next=Curr.next;           
            Curr.next=prev;
            prev=Curr;
            Curr=next;
        }
        
//         for(ListNode iNode = Curr; iNode!=null; iNode = next.next) {
//             ListNode next=Curr.next;
//             Curr.next=prev;
//             prev=Curr;
//             //Curr=next;
    
//         }

        return prev;
    }
}