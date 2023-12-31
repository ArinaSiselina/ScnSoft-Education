﻿namespace LeetCodeTraining.RegularExpressionMatching
{
    //https://leetcode.com/problems/regular-expression-matching/description/
    public class RegularExpressionMatchingSolution
    {
        public static bool IsMatch(string s, string p)
        {
            if (p.Length == 0)
            {
                return s.Length == 0;
            }

            bool firstMatch = s.Length > 0 && (p[0] == s[0] || p[0] == '.');

            if (p.Length >= 2 && p[1] == '*')
            {
                return (IsMatch(s, p.Substring(2)) || (firstMatch && IsMatch(s.Substring(1), p)));
            }

            return firstMatch && IsMatch(s.Substring(1), p.Substring(1));
        }
    }
}