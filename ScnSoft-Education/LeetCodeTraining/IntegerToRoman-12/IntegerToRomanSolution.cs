using System.Text;

namespace LeetCodeTraining.IntegerToRoman
{
    //https://leetcode.com/problems/integer-to-roman/
    public class IntegerToRomanSolution
    {
        public static string IntToRoman(int num)
        {
            int[] ints = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] romans = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            StringBuilder result = new StringBuilder();
            int i = 0;

            while (num > 0)
            {
                int div = num / ints[i];
                for (int j = 0; j < div; j++)
                {
                    result.Append(romans[i]);
                    num -= ints[i];
                }
                i++;
            }

            return result.ToString();
        }
    }
}
