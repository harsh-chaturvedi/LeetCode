namespace LT150;
//https://leetcode.com/problems/binary-tree-right-side-view/?envType=study-plan-v2&envId=top-interview-150

public static class RightViewBinaryTree
{
    public static IList<int> RightSideView(TreeNode root)
    {
        if (root == null)
            return new List<int>();

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
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