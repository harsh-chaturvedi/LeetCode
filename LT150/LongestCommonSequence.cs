namespace LT150;

public static class LongestCommonSequence
{
    public static int LongestConsecutive(int[] nums)
    {
        if(nums == null || !nums.Any())
            return 0;
        
        HashSet<int> set = new HashSet<int>();

        for(int i = 0 ; i < nums.Length; i++)
        {
            set.Add(nums[i]);
        }

        int curlen = 0, maxlen = 0;
        foreach(var item in set)
        {
            curlen = 1;
            if(!set.Contains(item-1))
            {
                while(set.Contains(item + curlen))
                {
                    curlen++;
                }

                maxlen = Math.Max(curlen, maxlen);
            }
        }

        return maxlen;
    }
}