namespace LeetCodeTraining.DivideTwoIntegers
{
    //https://leetcode.com/problems/divide-two-integers/
    public class DivideTwoIntegersSolution
    {
        public static int Divide(int dividend, int divisor)
        {
            if (divisor == 0) return int.MaxValue;
            if (dividend == int.MinValue && divisor == -1) return int.MaxValue;

            int sign = (dividend < 0) ^ (divisor < 0) ? -1 : 1;
            long dvd = Math.Abs((long)dividend);
            long dvs = Math.Abs((long)divisor);

            int result = 0;
            while (dvd >= dvs)
            {
                long temp = dvs, multiple = 1;
                while (dvd >= (temp << 1))
                {
                    temp <<= 1;
                    multiple <<= 1;
                }
                dvd -= temp;
                result += (int)multiple;
            }

            return sign == 1 ? result : -result;
        }
    }
}
