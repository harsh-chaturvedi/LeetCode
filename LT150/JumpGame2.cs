namespace LT150;
//https://leetcode.com/problems/jump-game-ii/?envType=study-plan-v2&envId=top-interview-150

public static class JumpGame2
{
    public static int Jump(int[] nums)
    {
        if (nums == null || !nums.Any())
            return 0;
        if (nums.Length == 1)
            return 1;

        int totalJump = 0, i = 0;

        while (i < nums.Length)
        {
            if (i == nums.Length - 1)
                break;
            int allowedjums = nums[i];
            int maxJumps = nums[i];
            int controlIndex = i + 1;
            for (int j = i + 1; j <= i + allowedjums && j <= nums.Length; j++)
            {
                if (nums[j] > maxJumps)
                {
                    maxJumps = nums[j];
                    controlIndex = j;
                }

                if (j >= nums.Length - 1)
                    break;
            }

            if(i+maxJumps >= nums.Length-1)
                return totalJump;

            i = controlIndex;
            totalJump++;
        }

        return totalJump;
    }
}