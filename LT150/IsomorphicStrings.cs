namespace LT150;
//https://leetcode.com/problems/isomorphic-strings/description/?envType=study-plan-v2&envId=top-interview-150

public static class IsIsomorphicStrings
{
    public static bool IsIsomorphic(string s, string t)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            return false;

        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> dictS = new Dictionary<char, int>();
        Dictionary<char, int> dictT = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (!dictS.ContainsKey(c))
                dictS.Add(c, 0);

            dictS[c] = dictS[c] + 1;
        }

        foreach (char c in t)
        {
            if (!dictT.ContainsKey(c))
                dictT.Add(c, 0);

            dictT[c] = dictT[c] + 1;
        }

        if (dictS.Keys.Count != dictT.Keys.Count)
            return false;

        var vals = dictS.Values.ToArray();
        Array.Sort(vals);
        var valT = dictT.Values.ToArray();
        Array.Sort(valT);

        for (int i = 0; i < vals.Length; i++)
        {
            if (vals[i] != valT[i])
                return false;
        }

        dictS = dictS.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        dictT = dictT.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        for (int i = 0; i < dictS.Count; i++)
        {
            var origChar = dictS.ElementAt(i).Key;
            var replaceChar = dictT.ElementAt(i).Key;

            s = s.Replace(origChar, replaceChar);
        }

        return s.Equals(t);
    }
}