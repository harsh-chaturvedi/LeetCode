using System.Collections.Generic;

namespace LT150;
//https://leetcode.com/problems/3sum/?envType=study-plan-v2&envId=top-interview-150

public static class Three3Sums
{
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        int i = 0, j = 0, k = 0;
        IList<IList<int>> list;
        list = new List<IList<int>>();

        Dictionary<int, Dictionary<int, int>> dict = new Dictionary<int, Dictionary<int, int>>();
        Array.Sort(nums);

        while (i < nums.Length)
        {
            j = i + 1;
            k = nums.Length - 1;
            var target = -nums[i];
            while (j < k)
            {
                if (i == j)
                    j++;
                if (i == k)
                    k--;

                if (nums[j] + nums[k] == target)
                {
                    if (!dict.ContainsKey(nums[i]))
                        dict.Add(nums[i], new Dictionary<int, int>());

                    if (!dict[nums[i]].ContainsKey(nums[j]))
                        dict[nums[i]].Add(nums[j], nums[k]);

                    //list.Add(new List<int> { nums[i], nums[j], nums[k] });
                    j++;
                }
                else if (nums[j] + nums[k] < target)
                    j++;
                else
                    k--;
            }
            i++;
        }

        foreach (var dicItem in dict)
        {
            var key = dicItem.Key;

            foreach (var item in dicItem.Value)
                list.Add(new List<int> { key, item.Key, item.Value });

        }

        return list;
    }
}