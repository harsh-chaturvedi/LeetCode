namespace LT150;
//https://leetcode.com/problems/same-tree/description/?envType=study-plan-v2&envId=top-interview-150

public static class SameTree
{
    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;
        else if (p != null && q == null)
            return false;
        else if (p == null && q != null)
            return false;
        else if (p.val != q.val)
            return false;

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}