namespace LeetCodeTraining.SortColors
{
    //https://leetcode.com/problems/sort-colors/
    public class SortColorsSolution
    {
        public static void SortColors(int[] nums)
        {
            int low = 0, mid = 0, high = nums.Length - 1;
            while (mid <= high)
            {
                switch (nums[mid])
                {
                    case 0:
                        Swap(ref nums[low++], ref nums[mid++]);
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        Swap(ref nums[mid], ref nums[high--]);
                        break;
                }
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
