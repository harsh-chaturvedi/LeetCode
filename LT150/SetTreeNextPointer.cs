namespace LT150;
//https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii/description/?envType=study-plan-v2&envId=top-interview-150

public static class SetTreeNextPointer
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

    public static Node Connect(Node root)
    {
        if (root == null)
            return null;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);
        queue.Enqueue(null);

        while (queue.Count != 1)
        {
            int count = queue.Count;
            Node prev = null;

            for (int i = 0; i < count; i++)
            {
                var internalNode = queue.Dequeue();

                if (internalNode == null)
                    queue.Enqueue(null);

                if (prev != null)
                    prev.next = internalNode;

                prev = internalNode;

                if (internalNode != null && internalNode.left != null)
                    queue.Enqueue(internalNode.left);

                if (internalNode != null && internalNode.right != null)
                    queue.Enqueue(internalNode.right);
            }
        }

        return root;
    }
}