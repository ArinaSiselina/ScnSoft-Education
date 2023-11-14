namespace LeetCodeTraining.IsPalindrome1
{
    //https://leetcode.com/problems/palindrome-number/
    public class PalindromeSolution
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0))
            {
                return false;
            }

            int reversed = 0;
            int orig = x;

            while (x > 0)
            {
                int digit = x % 10;
                reversed = reversed * 10 + digit;
                x /= 10;
            }
            return orig == reversed;
        }
    }
}
