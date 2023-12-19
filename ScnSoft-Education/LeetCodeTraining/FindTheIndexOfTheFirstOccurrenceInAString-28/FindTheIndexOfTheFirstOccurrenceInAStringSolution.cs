namespace LeetCodeTraining.FindTheIndexOfTheFirstOccurrenceInAString
{
    //https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
    public class FindTheIndexOfTheFirstOccurrenceInAStringSolution
    {
        public static int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                int j;

                for (j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                }

                if (j == needle.Length)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}