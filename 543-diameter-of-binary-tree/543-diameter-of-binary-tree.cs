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
    public int height(TreeNode root){
        return root==null?-1:Math.Max(height(root.left), height(root.right))+1;
    }
    
    public int DiameterOfBinaryTree(TreeNode root) {
        if(root==null) return 0;     
       
      int ld= DiameterOfBinaryTree(root.left);
      int rd= DiameterOfBinaryTree(root.right);
        
        int lh=height(root.left);
        int rh=height(root.right);
        int dia=lh+rh+2;
        return Math.Max(dia,Math.Max(ld,rd));
    }
}