namespace LeetCodeTraining.ReverseInteger
{
    //https://leetcode.com/problems/reverse-integer/description/
    public class ReverseIntegerSolution
    {
        public static int Reverse(int x)
        {
            int reversedX = 0;
            while (x != 0)
            {
                int digit = x % 10;
                x /= 10;
                if (reversedX > int.MaxValue / 10 || (reversedX == int.MaxValue / 10 && digit > 7))
                {
                    return 0;
                }
                if (reversedX < int.MinValue / 10 || (reversedX == int.MinValue / 10 && digit < -8))
                {
                    return 0;
                }
                reversedX = reversedX * 10 + digit;
            }
            return reversedX;
        }
    }
}