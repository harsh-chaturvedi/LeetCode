namespace LT150;
//https://leetcode.com/problems/minimum-size-subarray-sum/description/?envType=study-plan-v2&envId=top-interview-150

public static class MinimizeSizeSubArraySum
{
    public static int MinSubArrayLen(int target, int[] nums)
    {
        if (nums == null || !nums.Any())
            return 0;

        if (nums[0] == target)
            return 1;

        int left = 0, right = 0, currentSum = 0, minLen = Int32.MaxValue;

        while (left <= right)
        {

            if (currentSum < target)
            {
                currentSum += nums[right];
                right++;
            }

            else
            {
                int currLen = right - left;
                minLen = Math.Min(minLen, currLen);
                currentSum -= nums[left];
                left++;
            }

            if (right == nums.Length && currentSum < target)
                break;
        }

        if (minLen == Int32.MaxValue)
            return 0;

        return minLen;
    }
}