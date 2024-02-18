namespace LT150;
//https://leetcode.com/problems/valid-palindrome/?envType=study-plan-v2&envId=top-interview-150
public static class PalindromeCheck
{
    public static bool IsPalindrome(string s)
    {
        if (s.Length == 1)
            return true;

        char[] chars = s.ToCharArray();
        int low = 0, high = chars.Length - 1;


        //97-122 - && 65 - 90
        while (low <= high)
        {
            // int lowerCharVal = (int)chars[low];
            // int hgihCharVal = (int)chars[high];

            while (!CheckValidChar(chars, low)&& low < high)
            {
                low++;
            }

            while (!CheckValidChar(chars, high) && low < high)
            {
                high--;
            }

            if (chars[low] != chars[high])
                return false;

            low++;
            high--;
        }

        return true;
    }

    private static bool CheckValidChar(char[] chars, int index)
    {
        int charVal = (int)chars[index];
        if ((65 <= charVal && charVal <= 90) || (97 <= charVal && charVal <= 122))
            return true;

        return false;
    }
}