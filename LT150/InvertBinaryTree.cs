namespace LT150;
//https://leetcode.com/problems/invert-binary-tree/description/?envType=study-plan-v2&envId=top-interview-150

public static class InvertBinaryTree
{
    public static TreeNode InvertTree(TreeNode root)
    {
        if (root == null || (root.left == null && root.right == null))
            return root;

        InvertTree(root.left);
        InvertTree(root.right);

        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;

        return root;
    }
}