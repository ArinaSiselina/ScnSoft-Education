namespace LeetCodeTraining.GenerateParentheses
{
    // https://leetcode.com/problems/generate-parentheses/

    public class GenerateParenthesesSolution
    {
        public static IList<string> GenerateParentheses(int n)
        {
            IList<string> result = new List<string>();
            Backtrack(result, "", 0, 0, n);
            return result;
        }

        private static void Backtrack(IList<string> result, string current, int open, int close, int max)
        {
            if (current.Length == max * 2)
            {
                result.Add(current);
                return;
            }

            if (open < max)
            {
                Backtrack(result, current + "(", open + 1, close, max);
            }
            if (close < open)
            {
                Backtrack(result, current + ")", open, close + 1, max);
            }
        }
    }
}