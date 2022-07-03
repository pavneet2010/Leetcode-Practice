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
    public ListNode DeleteDuplicatesUnsorted(ListNode head) {
        if(head==null){
            return head;
        }
        Dictionary<int,bool> dict=new Dictionary<int,bool>();
        ListNode temp=head;
         while(temp!=null){
            if(!dict.ContainsKey(temp.val))
                dict.Add(temp.val, false);
            else
                dict[temp.val]=true;
            temp=temp.next;
        }
        ListNode result=new ListNode();
        //dict.Remove(k=>k.Value==true);
         temp= new ListNode(-1, head);
         result=temp;
        while(temp.next!=null){
            if(dict[temp.next.val])
                temp.next=temp.next.next;
            else
                temp=temp.next;
        }
        
        return result.next;
        
    }
}