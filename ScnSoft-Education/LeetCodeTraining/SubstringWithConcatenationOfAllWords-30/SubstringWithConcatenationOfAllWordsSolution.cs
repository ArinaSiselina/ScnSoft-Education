namespace LeetCodeTraining.SubstringWithConcatenationOfAllWords
{
    //https://leetcode.com/problems/substring-with-concatenation-of-all-words/
    public class SubstringWithConcatenationOfAllWordsSolution
    {
        public static IList<int> FindSubstring(string s, string[] words)
        {
            IList<int> result = new List<int>();
            if (string.IsNullOrEmpty(s) || words.Length == 0) return result;

            int wordLength = words[0].Length;
            int totalLength = wordLength * words.Length;

            var wordFrequency = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (wordFrequency.ContainsKey(word))
                {
                    wordFrequency[word]++;
                }
                else
                {
                    wordFrequency.Add(word, 1);
                }
            }

            for (int i = 0; i <= s.Length - totalLength; i++)
            {
                var seen = new Dictionary<string, int>();
                int j = 0;
                for (j = 0; j < words.Length; j++)
                {
                    int start = i + j * wordLength;
                    int end = start + wordLength;
                    string word = s.Substring(start, wordLength);
                    if (wordFrequency.ContainsKey(word))
                    {
                        if (seen.ContainsKey(word))
                        {
                            seen[word]++;
                        }
                        else
                        {
                            seen.Add(word, 1);
                        }
                        if (seen[word] > wordFrequency[word])
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if (j == words.Length)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}