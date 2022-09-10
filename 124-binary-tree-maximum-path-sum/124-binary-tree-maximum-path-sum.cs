/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    int max_sum=Int32.MinValue;
    public int MaxPathSum(TreeNode root) {        
        max_gain(root);
        return max_sum;        
    }
    
    private int  max_gain(TreeNode root){
        if(root==null) return 0;
        int left=Math.Max(max_gain(root.left),0);
         int right=Math.Max(max_gain(root.right),0);
        max_sum=Math.Max(max_sum,left+right+root.val);
        return Math.Max(left,right)+root.val;
    }
    
    
}