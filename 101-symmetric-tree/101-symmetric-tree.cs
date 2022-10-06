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
    public bool IsSymmetric(TreeNode root) => Validate(root.left, root.right);
    
    private bool Validate(TreeNode left, TreeNode right)
    {
        if ((left == null && right != null) ||
            (right == null && left != null) ||
            (left != null && right != null && left.val != right.val))
                return false;

        return left == null && right == null ? true :
            Validate(left.left, right.right) &&
                Validate(left.right, right.left) ;
    }
}