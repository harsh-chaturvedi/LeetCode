namespace LT150;
//https://leetcode.com/problems/sum-root-to-leaf-numbers/description/?envType=study-plan-v2&envId=top-interview-150

public static class SumRootToLeafNumbers
{
    static List<int> nums = new List<int>();
    public static int SumNumbers(TreeNode root)
    {
        if (root == null)
            return 0;

        Traverse(root, 0);
        int sum = 0;
        foreach (var item in nums)
        {
            sum += item;
        }


        return sum;
    }


    private static void Traverse(TreeNode current, int val)
    {
        //ensuring leaf node
        if (current.left == null && current.right == null)
        {
            nums.Add(val + current.val);
        }

        val += current.val;
        if (current.left != null)
            Traverse(current.left, val * 10);

        if (current.right != null)
            Traverse(current.right, val * 10);
    }
}