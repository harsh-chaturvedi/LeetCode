namespace LTDaily;

public static class BinaryTreeTopView
{
    static Dictionary<int, TreeNode> dict;
    public static List<int> TopView(TreeNode root)
    {
        dict = new Dictionary<int, TreeNode>();
        int sep= 0;
        //Your code here
        Traverse(root, sep);
        var list = dict.OrderBy(x => x.Key).Select(x => x.Value.val).ToList();
        return list;
    }
    
    
    public static void Traverse(TreeNode current, int sep)
    {
        if(current == null)
            return;
            
        if(!dict.ContainsKey(sep))
            dict.Add(sep, current);
            
        Traverse(current.left, sep - 1);
        Traverse(current.right, sep + 1);
            
    }
}