namespace LT150;
//https://leetcode.com/problems/jump-game/?envType=study-plan-v2&envId=top-interview-150
public static class JumpGame
{
    public static bool CanJump(int[] nums)
    {
        int end = nums.Length - 1;
        bool final = false;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            var reach = CheckReach(nums, i, end);
            if (reach)
                end--;
        }
        if (end > 0)
            return false;
        return true;
    }

    private static bool CheckReach(int[] nums, int current, int k)
    {
        return current + nums[current] >= k || current + nums[current] >= nums.Length - 1;
    }
}