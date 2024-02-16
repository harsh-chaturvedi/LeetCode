using System.Text;

namespace LT150;
//https://leetcode.com/problems/reverse-words-in-a-string/?envType=study-plan-v2&envId=top-interview-150

public class ReverseWords {
    public string Solve(string s) {

        if(s.Length == 1)
            return s;

        if(s == " ")
            return string.Empty;
        char[] chars = s.Trim().ToCharArray();

        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < chars.Length; i++)
        {
            if(chars[i] == ' ')
            {
                sb.Append(chars[i]);
                while(chars[i + 1] == ' ')
                i++;
            }
            else
            sb.Append(chars[i]);
        }

        int start = 0;
        for(int i = 0; i < chars.Length; i++)
        {
            if(chars[i] == ' ')
            {
                SwapPositions(chars, start, i-1);
                start = i+1;
            }
        }

        SwapPositions(chars, start, chars.Length-1);
        SwapPositions(chars, 0, chars.Length-1);

        return new String(chars);

    }

    private void SwapPositions(char[] chars, int start, int end)
    {
        while(start <= end)
        {
            char temp = chars[start];
            chars[start] = chars[end];
            chars[end] = temp;
            start++;
            end--;
        }
    }
}
