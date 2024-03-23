namespace LT150;
//https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/submissions/1211577654/?envType=study-plan-v2&envId=top-interview-150

public static class LowestCommonAncestor
{
    public static TreeNode LCA(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null)
            return null;

        if (root == p || root == q)
            return root;

        var left = LCA(root.left, p, q);
        var right = LCA(root.right, p, q);

        if (left != null && right != null)
            return root;

        if (left != null)
            return left;
        else
            return right;
    }
}