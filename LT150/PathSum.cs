namespace LT150;
//https://leetcode.com/problems/path-sum/?envType=study-plan-v2&envId=top-interview-150

public static class PathSum
{
    public static bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
            return false;

        int currentSum = 0;
        return Traverse(root, targetSum, currentSum);
    }

    private static bool Traverse(TreeNode current, int targetSum, int currentSum)
    {
        //ensuring leaf node
        if (current.left == null && current.right == null)
        {
            if ((currentSum + current.val) == targetSum)
                return true;
            else
                return false;
        }

        bool leftRes = false;
        if (current.left != null)
            leftRes = Traverse(current.left, targetSum, currentSum + current.val);

        bool rightRes = false;
        if (current.right != null)
            rightRes = Traverse(current.right, targetSum, currentSum + current.val);

        return leftRes || rightRes;
    }
}