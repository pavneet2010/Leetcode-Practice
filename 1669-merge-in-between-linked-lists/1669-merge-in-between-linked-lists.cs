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
   public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2) {
        var index = 0;    
        var start1 = list1;
        while (index < a-1) {
            start1 = start1.next;
            index++;
        }
        
		var end1 = start1;
        while (index < b+1) {
            end1 = end1.next;
            index++;
        }
        
        var end2 = list2;
        while (end2.next != null) {
            end2 = end2.next;
        }
        
        start1.next = list2;
        end2.next = end1;
        return list1;   
    }
}