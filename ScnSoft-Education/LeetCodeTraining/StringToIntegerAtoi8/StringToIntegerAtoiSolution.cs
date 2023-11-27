namespace LeetCodeTraining.StringToIntegerAtoi
{
    // https://leetcode.com/problems/string-to-integer-atoi/
    public class StringToIntegerAtoiSolution
    {
        public static int MyAtoi(string s)
        {
            s = s.TrimStart();
            if (string.IsNullOrEmpty(s)) return 0;

            bool isNegative = false;
            int index = 0;

            if (s[0] == '-' || s[0] == '+')
            {
                isNegative = s[0] == '-';
                index++;
            }

            long result = 0;
            while (index < s.Length && Char.IsDigit(s[index]))
            {
                result = result * 10 + (int)Char.GetNumericValue(s[index]);
                if (isNegative && -result < int.MinValue) return int.MinValue;
                if (!isNegative && result > int.MaxValue) return int.MaxValue;
                index++;
            }
            return isNegative ? (int)-result : (int)result;
        }
    }
}
