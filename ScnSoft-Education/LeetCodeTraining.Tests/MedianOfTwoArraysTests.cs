using LeetCodeTraining.MedianOfTwoArrays;

namespace LeetCodeTraining.Tests
{
    public class MedianOfTwoArraysSolutionTest
    {
        [Theory]
        [InlineData(new int[]{1, 3}, new int[]{2}, 2.00000)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.50000)]
        [InlineData(new int[] { 1, 3 }, new int[] { 5, 8 }, 4.00000)]
        public void MedianOfTwoArrays(int[] nums1, int[] nums2, double expectedResult)
        {
            //Act
            double result = MedianOfTwoArraysSolution.FindMedianSortedArrays(nums1, nums2);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
