using System.Text;
namespace LT150;

public static class ValidPalindrome
{
    public static bool IsPalindrome(string s)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in s)
        {
            if (CheckValidChar(c))
            {
                if ((int)c <= 97)
                {
                    sb.Append(c.ToString().ToLower().ToCharArray()[0]);
                }
                else
                    sb.Append(c);


            }

        }
        s = sb.ToString();
        if (s.Length == 1)
            return true;

        char[] chars = s.ToCharArray();
        int low = 0, high = chars.Length - 1;


        //97-122 - && 65 - 90
        while (low <= high)
        {
            // int lowerCharVal = (int)chars[low];
            // int hgihCharVal = (int)chars[high];

            while (!CheckValidChar(chars, low) && low < high)
            {
                low++;
            }

            while (!CheckValidChar(chars, high) && low < high)
            {
                high--;
            }

            int lowerCharVal = (int)chars[low];
            int highCharVal = (int)chars[high];

            var diff = Math.Abs(lowerCharVal - highCharVal);
            if (!(diff == 0 || diff == 32))
                //  || !Char.IsLetter(chars[low]) || !Char.IsLetter(chars[high]))
                return false;

            low++;
            high--;
        }

        return true;
    }

    private static bool CheckValidChar(char[] chars, int index)
    {
        int charVal = (int)chars[index];
        if ((65 <= charVal && charVal <= 90) || (97 <= charVal && charVal <= 122) || (48 <= charVal && charVal <= 57))
            return true;

        return false;
    }

    private static bool CheckValidChar(char c)
    {
        int charVal = (int)c;
        if ((65 <= charVal && charVal <= 90) || (97 <= charVal && charVal <= 122) || (48 <= charVal && charVal <= 57))
            return true;

        return false;
    }
}