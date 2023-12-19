namespace LeetCodeTraining.SortColors
{
    //https://leetcode.com/problems/sort-colors/
    public class SortColorsSolution
    {
        public static void SortColors(int[] nums)
        {
            int low = 0, mid = 0, high = nums.Length - 1;
            int temp;

            while (mid <= high)
            {
                switch (nums[mid])
                {
                    case 0:
                        temp = nums[low];
                        nums[low] = nums[mid];
                        nums[mid] = temp;
                        low++;
                        mid++;
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        temp = nums[high];
                        nums[high] = nums[mid];
                        nums[mid] = temp;
                        high--;
                        break;
                }
            }
        }
    }
}
