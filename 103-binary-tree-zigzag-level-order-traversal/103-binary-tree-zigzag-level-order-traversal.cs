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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
          var res = new List<IList<int>>();
        if (root == null) return res;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        int level = 0;
        
        while(q.Count != 0) {
            var size = q.Count;
            var nodes = new List<int>();
            for (int i=0; i<size; i++) {
                var node = q.Dequeue();
                nodes.Add(node.val);
                if (node.left != null) {
                    q.Enqueue(node.left);
                }
                if (node.right != null) {
                    q.Enqueue(node.right);
                }
            }
            if (level % 2 != 0) {
                // reverse
                nodes.Reverse();
            }
            res.Add(nodes);
            level++;
        }
        return res;
    }
}