namespace LT150;
//https://leetcode.com/problems/product-of-array-except-self/description/?envType=study-plan-v2&envId=top-interview-150
public static class ProductExceptSelf {
    public static int[] ProductSelf(int[] nums) {
        if(nums == null || !nums.Any())
            return new int[]{};

            if(nums.Length == 1)
                return new int[]{1};

        
        int[]left = new int[nums.Length];
        int[]right = new int[nums.Length];
        int[]product = new int[nums.Length];

        left[0] = 1; right[nums.Length-1] = 1;

        for(int i = 1; i < nums.Length; i++)
        {
            left[i] = nums[i-1] * left[i-1];
        }
        for(int j = nums.Length-2; j >= 0; j--)
        {
            right[j] = nums[j+1] * right[j+1];
        }

        for(int i = 0; i < nums.Length; i++)
        {
            product[i] = left[i] * right[i];
        }

        return product;
    }
}