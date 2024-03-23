namespace LT150;
//https://leetcode.com/problems/spiral-matrix/?envType=study-plan-v2&envId=top-interview-150

public static class SpiralMatrix
{
    public static IList<int> SpiralOrder(int[][] matrix)
    {
        int left = 0, top = 0, right = matrix[0].Length - 1, bottom = matrix.Length - 1;

        int[] res = new int[(right + 1) * (bottom + 1)];
        int counter = 0;

        while (left <= right && top <= bottom)
        {
            for (int i = left; i <= right; i++)
                res[counter++] = matrix[top][i];

            top++;
            for (int j = top; j <= bottom; j++)
                res[counter++] = matrix[j][right];

            right--;
            if (top <= bottom)
            {
                for (int k = right; k >= left; k--)
                    res[counter++] = matrix[bottom][k];

                bottom--;
            }

            if (left <= right)
            {
                for (int l = bottom; l >= top; l--)
                    res[counter++] = matrix[l][left];
                left++;
            }


        }

        return res;
    }
}