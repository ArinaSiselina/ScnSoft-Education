namespace LeetCodeTraining.ValidParentheses
{
    //https://leetcode.com/problems/valid-parentheses/
    public class ValidParenthesesSolution
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char bracket in s)
            {
                if (bracket == '(' || bracket == '{' || bracket == '[')
                {
                    stack.Push(bracket);
                    continue;
                }

                if (!stack.Any() ||
                    (bracket == ')' && stack.Peek() != '(') ||
                    (bracket == '}' && stack.Peek() != '{') ||
                    (bracket == ']' && stack.Peek() != '['))
                {
                    return false;
                }

                stack.Pop();
            }

            return !stack.Any();
        }
    }
}
