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
    List<int> a =new List<int>();
    public List<int> InorderTraversal(TreeNode root) {
        if(root==null)
            return new List<int>();
        InorderTraversal(root.left);
        a.Add(root.val);
        InorderTraversal(root.right);
        return a;
    }
}