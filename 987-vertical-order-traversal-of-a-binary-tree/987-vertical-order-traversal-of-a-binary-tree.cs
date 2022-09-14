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
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        
        SortedDictionary<int, SortedDictionary<int, List<int>>> d = new ();
        
        int min = 0, max = 0;
        Solve(root, 0, 0);
        
        List<IList<int>> ans = new ();
        foreach (var (col, t) in d) {
            List<int> current = new List<int>();
            foreach (var (row, e) in t) current.AddRange(e.OrderBy(x => x));
            ans.Add(current);
        }
        return ans;
        
        void Solve(TreeNode node, int row, int col) {
            if (!d.ContainsKey(col)) d[col] = new ();
            if (!d[col].ContainsKey(row)) d[col][row] = new ();
            d[col][row].Add(node.val);
            
            if (node.left != null) Solve(node.left, row + 1, col - 1);
            if (node.right != null) Solve(node.right, row + 1, col + 1);
        }
    }
}