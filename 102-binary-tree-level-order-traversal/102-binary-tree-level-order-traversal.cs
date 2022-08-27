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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var lst=new List<IList<int>>();        
        Queue<TreeNode> queue=new Queue<TreeNode>();
        queue.Enqueue(root);
        
        if(root==null) {
            return lst;
        }
        while(queue.Count>0){
            var count = queue.Count;
            var level = new List<int>();
            for (var i = 0; i < count; i++)
            {
                var n = queue.Dequeue();
                level.Add(n.val);
                if (n.left != null)
                    queue.Enqueue(n.left);
                if (n.right != null)
                    queue.Enqueue(n.right);
            }
            lst.Add(level);
        }
        return lst;
        
    }
}