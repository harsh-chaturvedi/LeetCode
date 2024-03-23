namespace LTDaily;
//https://leetcode.com/problems/sliding-window-maximum/description/
public static class MaximumElementsAllSubArraySizeK
{
    public static int[] MaxSlidingWindow(int[] nums, int k)
    {
        int left = 0, right = 0;

        int[] max = new int[nums.Length - k + 1];
        int currMax = Int32.MinValue;
        int currMaxPos = -1;
        while (right < k)
        {
            if (nums[right] > currMax)
            {
                currMax = nums[right];
                currMaxPos = right;
            }
            right++;
        }

        max[0] = currMax;
        int prevMax = currMax;
        left++;
        int counter = 0;
        while (right < nums.Length)
        {
            //prev high lies in current window, compare 
            // prev high with incoming element and update
            if (left <= currMaxPos && currMaxPos <= right)
            {
                if (nums[right] > currMax)
                {
                    currMax = nums[right];
                    currMaxPos = right;
                }
            }
            else
            {
                //prev high lies outside of current window
                //we have two cases - 
                //1 .prev high is less than current
                //then current will be high, as all subsequent elements are less
                //2. prev high is more than current
                // we have recompute the high element
                if (nums[right] > currMax)
                {
                    currMax = nums[right];
                    currMaxPos = right;
                }
                else
                {
                    currMax = nums[left];
                    currMaxPos = left;
                    for (int i = left; i <= right; i++)
                    {
                        if (nums[i] > currMax)
                        {
                            currMax = nums[i];
                            currMaxPos = i;
                        }
                    }
                }
            }

            counter++;
            max[counter] = currMax;
            left++;
            right++;
        }

        return max;
    }
}