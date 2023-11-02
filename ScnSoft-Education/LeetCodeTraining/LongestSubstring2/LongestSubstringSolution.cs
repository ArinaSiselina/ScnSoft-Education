namespace LeetCodeTraining.LongestSubstring1;

public class SubstringSolution
{
    public static int LengthOfLongestSubstring(string s)
    {
        int maxLength = 0;
        int start = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char currentChar = s[i];
            int index = s.IndexOf(currentChar, start, i - start);
            if (index != -1)
            {
                start = index + 1;
            }
            maxLength = Math.Max(maxLength, i - start + 1);
        }
        return maxLength;
    }
}