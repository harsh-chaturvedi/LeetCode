namespace LT150;

//https://leetcode.com/problems/trapping-rain-water/?envType=study-plan-v2&envId=top-interview-150

public class TrapRainWater {
    public int Trap(int[] height) {
        
        if(height == null || !height.Any() || height.Length < 3)
            return 0;

        int totalWater = 0;

        Stack<int> stack= new Stack<int>();
        int[] prevGreaterElement = new int[height.Length];

        stack.Push(height[0]);
        prevGreaterElement[0] = -1;

        for(int i =  1; i < height.Length; i++)
        {
            while(stack.Any() && height[i] >= stack.Peek())
                stack.Pop();

            if(stack.Any())
                prevGreaterElement[i] = stack.Peek();
                else
                prevGreaterElement[i] = -1;

            stack.Push(height[i]);
        }     

        stack.Clear();
        stack.Push(height[height.Length-1]);
        int[] nextGreaterElement = new int[height.Length];

        for(int i = height.Length-2; i >= 0; i-- )
        {
            while(stack.Any() && height[i] >= stack.Peek())
                stack.Pop();

            if(stack.Any())
                nextGreaterElement[i] = stack.Peek();
            else
                nextGreaterElement[i] = -1;

            stack.Push(height[i]);
        }

        for(int i = 1; i < height.Length - 1; i++)
        {
            if(nextGreaterElement[i] == -1 || prevGreaterElement[i] == -1)
                continue;

            totalWater += Math.Min(nextGreaterElement[i], prevGreaterElement[i]) - height[i];
        }

        return totalWater;
    }
}