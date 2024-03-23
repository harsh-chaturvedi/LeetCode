namespace LT150;
//https://leetcode.com/problems/maximum-depth-of-binary-tree/description/?envType=study-plan-v2&envId=top-interview-150


//Definition for a binary tree node.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class MaximumDepthBinaryTree
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;

        int lh = MaxDepth(root.left);
        int rh = MaxDepth(root.right);

        return 1 + Math.Max(lh, rh);
    }
}