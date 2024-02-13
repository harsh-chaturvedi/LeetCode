namespace LT150;
//https://leetcode.com/problems/roman-to-integer/?envType=study-plan-v2&envId=top-interview-150
public static class RomanToInt
{
    public static int Convert(string s)
    {

        if (string.IsNullOrEmpty(s))
            return 0;


        char[] charArray = s.ToCharArray();

        Dictionary<char, int> dict = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };

        int num = 0;

        //char nextChar, currentChar = charArray[0];
        int i = 0;
        for (; i < charArray.Length - 1;)
        {
            int nextVal = dict[charArray[i + 1]];
            int currVal = dict[charArray[i]];

            if (currVal < nextVal)
            {
                num += nextVal - currVal;
                i += 2;
            }
            else
            {
                num += currVal;
                i++;
            }

        }

        if (i < charArray.Length)
        {
            int nextVal = dict[charArray[charArray.Length - 1]];
            int currVal = dict[charArray[charArray.Length - 2]];

            if (currVal < nextVal)
            {
                num += nextVal - currVal - currVal;
                // i+=2;
            }
            else
            {
                num += nextVal;
                // i++;
            }
        }

        return num;
    }
}