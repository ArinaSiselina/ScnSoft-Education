﻿namespace LeetCodeTraining.ValidParentheses
{
    //https://leetcode.com/problems/palindrome-number/
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
                }
                else
                {
                    if (stack.Count == 0 || (bracket == ')' && stack.Peek() != '(') ||
                       (bracket == '}' && stack.Peek() != '{') ||
                       (bracket == ']' && stack.Peek() != '['))
                    {
                        return false;
                    }

                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }
    }
}
