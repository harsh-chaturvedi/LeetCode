namespace LT150;

//https://leetcode.com/problems/game-of-life/?envType=study-plan-v2&envId=top-interview-150

public static class GameofLife
{
    public static void Play(int[][] board)
    {

        int xlimit = board.Length;
        int ylimit = board[0].Length;
        if (xlimit < 2 || ylimit < 2)
        {
            board = board.Select(a => a.Select(b => 0).ToArray()).ToArray();
            return;

        }

        int[][] newb = board.Select(a => a.ToArray()).ToArray();

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                var currVal = GetValue1(newb, i, j);
                if (currVal == 3)
                    board[i][j] = 1;
                if (currVal < 2)
                    board[i][j] = 0;
                if (currVal > 3)
                    board[i][j] = 0;
            }
        }
    }

    private static int GetValue1(int[][] board, int i, int j)
    {
        List<int> vals = GetNeighbourValues(board, i, j);
        int val = 0;
        foreach (int item in vals)
        {
            if (item == 1)
                val++;
        }

        return val;
    }

    private static List<int> GetNeighbourValues(int[][] board, int i, int j)
    {
        int xlimit = board.Length - 1;
        int ylimit = board[0].Length - 1;

        List<int> nums = new List<int>();

        if (i == 0)
        {
            if (j == 0)
            {
                nums.Add(board[i][j + 1]);
                nums.Add(board[i + 1][j + 1]);

                nums.Add(board[i + 1][j]);
            }
            else if (0 < j && j < ylimit)
            {
                nums.Add(board[i][j + 1]);
                nums.Add(board[i + 1][j + 1]);

                nums.Add(board[i][j - 1]);
                nums.Add(board[i + 1][j - 1]);

                nums.Add(board[i + 1][j]);
            }
            else
            {
                nums.Add(board[i][j - 1]);
                nums.Add(board[i + 1][j - 1]);

                nums.Add(board[i + 1][j]);
            }
        }
        else if (0 < i && i < xlimit)
        {
            if (j == 0)
            {
                nums.Add(board[i - 1][j + 1]);
                nums.Add(board[i][j + 1]);
                nums.Add(board[i + 1][j + 1]);

                nums.Add(board[i + 1][j]);
                nums.Add(board[i - 1][j]);
            }
            else if (0 < j && j < ylimit)
            {
                nums.Add(board[i - 1][j + 1]);
                nums.Add(board[i][j + 1]);
                nums.Add(board[i + 1][j + 1]);

                nums.Add(board[i - 1][j - 1]);
                nums.Add(board[i][j - 1]);
                nums.Add(board[i + 1][j - 1]);

                nums.Add(board[i - 1][j]);
                nums.Add(board[i + 1][j]);
            }
            else
            {
                nums.Add(board[i - 1][j - 1]);
                nums.Add(board[i][j - 1]);
                nums.Add(board[i + 1][j - 1]);

                nums.Add(board[i + 1][j]);
                nums.Add(board[i - 1][j]);
            }
        }
        else
        {
            if (j == 0)
            {
                nums.Add(board[i - 1][j + 1]);
                nums.Add(board[i][j + 1]);

                nums.Add(board[i - 1][j]);
            }
            else if (0 < j && j < ylimit)
            {
                nums.Add(board[i - 1][j + 1]);
                nums.Add(board[i][j + 1]);

                nums.Add(board[i - 1][j - 1]);
                nums.Add(board[i][j - 1]);

                nums.Add(board[i - 1][j]);
            }
            else
            {
                nums.Add(board[i - 1][j - 1]);
                nums.Add(board[i][j - 1]);

                nums.Add(board[i - 1][j]);
            }
        }
        return nums;
    }
}