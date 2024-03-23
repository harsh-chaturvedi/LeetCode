namespace LT150;
//https://leetcode.com/problems/average-of-levels-in-binary-tree/submissions/1211606334/?envType=study-plan-v2&envId=top-interview-150

public static class LevelAverageBinaryTree
{
    public static IList<double> AverageOfLevels(TreeNode root) {
        if(root == null)
            return new List<double>();
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        List<double> lst = new List<double>();
        while(queue.Count != 0)
        {
            int count = queue.Count;
            double sum = 0;
            for(int i = 0; i < count; i++)
            {
                var internalNode = queue.Dequeue();
                sum += internalNode.val;

                if(internalNode.left != null)
                    queue.Enqueue(internalNode.left);

                if(internalNode.right != null)
                    queue.Enqueue(internalNode.right);
            }

            double mean = sum/count;
            lst.Add(mean);
        }

        return lst;
    }
}