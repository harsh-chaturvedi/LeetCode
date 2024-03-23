namespace LTDaily;
//https://leetcode.com/problems/binary-tree-right-side-view/description/

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

public static class BinaryTreeRightView
{
    public static List<int> Print(TreeNode current)
    {
        if (current == null)
            return new List<int>();

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(current);
        List<int> vals = new List<int>();

        while (queue.Count != 0)
        {
            int Count = queue.Count;

            for (int i = 0; i < Count; i++)
            {
                var internalNode = queue.Dequeue();

                if (internalNode.left != null)
                    queue.Enqueue(internalNode.left);
                if (internalNode.right != null)
                    queue.Enqueue(internalNode.right);

                if (i == Count - 1)
                    vals.Add(internalNode.val);
            }
        }

        return vals;
    }
}