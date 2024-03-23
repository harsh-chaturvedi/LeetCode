namespace LT150;
//https://leetcode.com/problems/binary-tree-level-order-traversal/?envType=study-plan-v2&envId=top-interview-150

public static class LevelOrderTraversalBinaryTree
{
    public static IList<IList<int>> LevelOrder(TreeNode root)
    {
        if (root == null)
            return new List<IList<int>>();

        Queue<TreeNode> queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        IList<IList<int>> lst = new List<IList<int>>();
        while (queue.Count != 0)
        {
            int count = queue.Count;
            List<int> cur = new List<int>();

            for (int i = 0; i < count; i++)
            {
                var internalNode = queue.Dequeue();
                cur.Add(internalNode.val);

                if (internalNode.left != null)
                    queue.Enqueue(internalNode.left);

                if (internalNode.right != null)
                    queue.Enqueue(internalNode.right);
            }
            lst.Add(cur);

        }

        return lst;
    }
}