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
    private int result=0;
    private int adds=0;
    public int sum(TreeNode root){
        
        return root==null?0:root.val+sum(root.left)+sum(root.right);
        
    }
    public int FindTilt(TreeNode root) {
     if(root==null) return 0;
        
       FindTilt(root.left);        
       FindTilt(root.right);
        if(root.left==null&& root.right==null){            
            return 0;
        }
        else{
          result+= Math.Abs(sum(root.left)-sum(root.right));            
        }
        
        return result;
    }
}