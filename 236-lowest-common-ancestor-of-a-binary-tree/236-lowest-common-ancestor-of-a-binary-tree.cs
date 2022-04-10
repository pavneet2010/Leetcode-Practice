/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public List<TreeNode> NodeToRootPath(TreeNode root, int data){       
        if(root==null){
            return new List<TreeNode>();
        }        
        if(root.val==data){
             List<TreeNode> resultStart=new List<TreeNode>();
            resultStart.Add(root);
            return resultStart;
        }        
        List<TreeNode> leftResult=NodeToRootPath(root.left,data);
        if(leftResult.Count>0){
            leftResult.Add(root);
            return leftResult;
        }
        List<TreeNode> rightResult=NodeToRootPath(root.right,data);
        if(rightResult.Count>0){
             rightResult.Add(root);
            return rightResult;
        }
        return new List<TreeNode>();
        
    }
    
    
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root==null){
            return null;
        }
        List<TreeNode> N2rP=NodeToRootPath(root,p.val);
        List<TreeNode> N2rq=NodeToRootPath(root,q.val);
        
         int i=N2rP.Count-1;
         int j=N2rq.Count-1;
        TreeNode result=new TreeNode();
        while(i>=0 && j>=0){
           
            if(N2rP[i].val==N2rq[j].val){
                 result=N2rq[j];
            }
           
            i--;
            j--;
        }
        return result;
        
    }
}