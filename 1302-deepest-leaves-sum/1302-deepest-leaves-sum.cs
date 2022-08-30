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
    public int DeepestLeavesSum(TreeNode root) {
        var list=new List<List<int>>();
         Queue<TreeNode> q=new Queue<TreeNode>();
        q.Enqueue(root);
        if(root==null){
            return 0;
        }
        while(q.Count>0){
            var count = q.Count;
              var level = new List<int>();
            for (var i = 0; i < count; i++)
            {
                var n = q.Dequeue();
                level.Add(n.val);
                if (n.left != null)
                    q.Enqueue(n.left);
                if (n.right != null)
                    q.Enqueue(n.right);
            }
            list.Add(level);
        }
        var a= list[list.Count-1];
        int result=0;
        foreach(int i in a ){
            result+=i;
        }
        return result;
    }
}