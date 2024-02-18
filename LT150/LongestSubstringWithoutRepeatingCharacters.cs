namespace LT150;
//https://leetcode.com/problems/longest-substring-without-repeating-characters/?envType=study-plan-v2&envId=top-interview-150

public static class LongestSubstringWithoutRepeatingCharacters
{
    public static int LengthOfLongestSubstring(string s)
    {
        int[] chars = new int[256];
        Array.Fill(chars, -1);
        int curlen = 0, maxlen = 0;
        if (string.IsNullOrEmpty(s))
            return 0;

        int prevIndex = -1, indexVal = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int index = (int)s[i];
            indexVal = chars[index];
            if (indexVal != -1)
                prevIndex = Math.Max(prevIndex, indexVal);
            curlen = prevIndex == -1 ? i + 1 : i - prevIndex;
            maxlen = Math.Max(maxlen, curlen);
            chars[index] = i;
        }

        return maxlen;
    }
}