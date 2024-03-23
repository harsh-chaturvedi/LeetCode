namespace LT150;
//https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/description/?envType=study-plan-v2&envId=top-interview-150

public static class ZigzagLevelOrderTraversal
{
    public static IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        if (root == null)
            return new List<IList<int>>();

        Stack<TreeNode> s1 = new Stack<TreeNode>();
        Stack<TreeNode> s2 = new Stack<TreeNode>();

        s1.Push(root);

        IList<IList<int>> lst = new List<IList<int>>();
        while (s1.Count != 0 || s2.Count != 0)
        {
            var current1 = new List<int>();
            while (s1.Count != 0)
            {
                var internalNode = s1.Pop();
                current1.Add(internalNode.val);
                Console.Write($"{internalNode.val}, ");

                if (internalNode.left != null)
                    s2.Push(internalNode.left);

                if (internalNode.right != null)
                    s2.Push(internalNode.right);
            }

            if (current1.Any())
                lst.Add(current1);
            var current2 = new List<int>();

            while (s2.Count != 0)
            {
                var internalNode = s2.Pop();
                current2.Add(internalNode.val);
                Console.Write($"{internalNode.val}, ");

                if (internalNode.right != null)
                    s1.Push(internalNode.right);

                if (internalNode.left != null)
                    s1.Push(internalNode.left);
            }
            
            if (current2.Any())
                lst.Add(current2);
        }

        return lst;
    }
}