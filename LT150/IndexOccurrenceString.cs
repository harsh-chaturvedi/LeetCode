namespace LT150;
//https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/submissions/1175044891/?envType=study-plan-v2&envId=top-interview-150

public static class IndexOccurrenceString
{
    public static int StrStr(string haystack, string needle)
    {
        int findHash = 0, rollingHash = 0;

        foreach (char c in needle)
        {
            findHash += (int)c;
        }

        if (needle.Length > haystack.Length)
            return -1;

        int i = 0;
        char[] chars = haystack.ToCharArray();
        for (; i < needle.Length; i++)
        {
            rollingHash += (int)chars[i];
        }

        while (i < haystack.Length)
        {
            if (rollingHash == findHash)
            {
                bool valid = true;
                for(int j = 0; j < needle.Length; j++)
                {
                    if (needle[j] != haystack[i - needle.Length + j])
                    {
                        valid = false;
                        break;
                    }
                        //return i - needle.Length;
                }
                

                if (valid)
                    return i - needle.Length;
            }



            rollingHash += ((int)chars[i] - (int)chars[i - needle.Length]);
            i++;

        }

        if (rollingHash == findHash)
            return i - needle.Length;

        return -1;
    }
}