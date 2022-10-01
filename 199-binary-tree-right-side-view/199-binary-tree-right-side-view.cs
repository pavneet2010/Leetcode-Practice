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
    public IList<int> RightSideView(TreeNode root) {
        List<int> result = new List<int>();
        RightSideDFS(root, 1, result);
        return result;
    }
    private void RightSideDFS(TreeNode node, int depth, List<int> result) {
        if (node == null)
            return;
        if (result.Count < depth)
            result.Add(node.val);
        RightSideDFS(node.right, depth+1, result);
        RightSideDFS(node.left, depth+1, result);
    }
}