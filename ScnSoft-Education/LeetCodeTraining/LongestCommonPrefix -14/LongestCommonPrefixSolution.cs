namespace LeetCodeTraining.LongestCommonPrefix
{
    //https://leetcode.com/problems/longest-common-prefix/
    public class LongestCommonPrefixSolution
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            Array.Sort(strs);

            int lengthMin = strs[0].Length;
            int i = 0;

            while (i < lengthMin && strs[0][i] == strs[strs.Length - 1][i])
            {
                i++;
            }

            return strs[0].Substring(0, i);
        }
    }
}
