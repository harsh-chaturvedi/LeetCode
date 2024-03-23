namespace LT150;
//https://leetcode.com/problems/summary-ranges/?envType=study-plan-v2&envId=top-interview-150

public static class SummaryRanges
{
    public static IList<string> Solve(int[] nums)
    {
        if (nums == null || !nums.Any())
            return new List<string>();
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict.Add(nums[0], -1);
        int counter = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (Math.Abs(nums[i + 1] - nums[i]) == 1)
            {
                var key = dict.ElementAt(counter).Key;
                dict[key] = nums[i];
                Console.WriteLine(nums[i]);
                // var key = dict.ElementAt(counter).Key;
                // var value = dict[key];

                // if (nums[i] > value)
                // {
                //     dict.Add(nums[i], -1);
                // }

            }
            else
            {
                var key = dict.ElementAt(counter).Key;
                dict[key] = nums[i];
                i++;
                dict.Add(nums[i], -1);
                counter++;
            }
        }

        for (int j = nums.Length - 2; j < nums.Length; j++)
        {
            if (!dict.ContainsKey(nums[j]) && !dict.Values.Any(x => x == nums[j]))
            {
                var key = dict.ElementAt(counter).Key;
                var val = dict[key];
                var comparator = val == -1 ? key : val;
                if (Math.Abs(nums[j] - comparator) != 1 && Math.Abs(nums[j] - comparator) != 0)
                {
                    dict.Add(nums[j], -1);
                    counter++;
                }
                else
                {
                    dict[key] = nums[j];
                }
            }
        }

        List<string> lst = new List<string>();
        foreach (var item in dict)
        {
            if (item.Key != item.Value && item.Value != -1)
                lst.Add($"{item.Key}->{item.Value}");
            else
                lst.Add($"{item.Key}");
        }

        return lst;
    }
}