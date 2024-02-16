namespace LT150;
//https://leetcode.com/problems/container-with-most-water/submissions/1176733213/?envType=study-plan-v2&envId=top-interview-150

public static class ContainerWater
{
    public static int MaxArea(int[] height)
    {
        int currentWater = 0, maxWater = 0;
        int low = 0, high = height.Length - 1;

        while (low < high)
        {
            currentWater = (high - low) * Math.Min(height[low], height[high]);
            maxWater = Math.Max(currentWater, maxWater);
            if (height[low] <= height[high])
                low++;
            else
                high--;
        }

        return maxWater;
    }
}