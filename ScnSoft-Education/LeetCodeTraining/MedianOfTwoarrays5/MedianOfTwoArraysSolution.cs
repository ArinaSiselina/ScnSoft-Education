namespace LeetCodeTraining.MedianOfTwoArrays
{
    //https://leetcode.com/problems/median-of-two-sorted-arrays/
    public class MedianOfTwoArraysSolution
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int n = nums1.Length + nums2.Length;
            int[] merged = new int[n];
            int i = 0, j = 0, k = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    merged[k++] = nums1[i++];
                }
                else
                {
                    merged[k++] = nums2[j++];
                }
            }

            while (i < nums1.Length)
            {
                merged[k++] = nums1[i++];
            }

            while (j < nums2.Length)
            {
                merged[k++] = nums2[j++];
            }

            if (n % 2 == 0)
            {
                return (merged[n / 2 - 1] + merged[n / 2]) / 2.0;
            }
            67return merged[n / 2];
        }
    }
}