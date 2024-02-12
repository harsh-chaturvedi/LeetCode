namespace LT150;

//https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/?envType=study-plan-v2&envId=top-interview-150
//constraints - Space Complexity O(1)

public static class RemoveDuplicateSortedArray2
{
    public static int RemoveDuplicates(int[] nums)
    {
        int sortedPointer = 0;
        int unsortedPointer = 1;
        int counter = 0;
        int currentCounter = 1;
        bool moved = false;

        if (nums == null)
            return 0;
        if (!nums.Any() || nums.Length < 3)
            return nums.Length;

        while (unsortedPointer < nums.Length && sortedPointer < nums.Length)
        {
            if (nums[unsortedPointer] == nums[unsortedPointer - 1])
            {
                if (moved)
                {
                    nums[sortedPointer + currentCounter] = nums[unsortedPointer];
                }
                if (currentCounter < 2)
                {
                    currentCounter++;
                    //sortedPointer++;
                }
                
            }
            else
            {
                sortedPointer += currentCounter;
                counter += currentCounter;
                nums[sortedPointer] = nums[unsortedPointer];
                currentCounter = 1;
                moved = true;
            }
            unsortedPointer++;
        }

        if (currentCounter > 0)
        {
            sortedPointer += currentCounter - 1;
            //counter += currentCounter - 1;
            nums[sortedPointer] = nums[unsortedPointer - 1];
            //currentCounter = 1;
        }

        Console.WriteLine("K - " + (counter + currentCounter));
        foreach (var n in nums) Console.Write($"{n} ");

        return counter;
    }
}