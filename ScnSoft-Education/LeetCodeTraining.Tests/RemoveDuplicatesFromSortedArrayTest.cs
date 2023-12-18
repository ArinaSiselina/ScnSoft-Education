using LeetCodeTraining.RemoveDuplicatesFromSortedArray;

namespace LeetCodeTraining.Tests
{
    public class RemoveDuplicatesFromSortedArraySolutionTest
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, 2, new int[] { 1, 2 })]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, new int[] { 0, 1, 2, 3, 4 })]
        public void RemoveDuplicatesFromSortedArray(int[] nums, int expectedResult, int[] expectedUniqueValues)
        {
            //Act
            int result = RemoveDuplicatesFromSortedArraySolution.RemoveDuplicates(nums);

            //Assert
            Assert.Equal(expectedResult, result);

            for (int i = 0; i < result; i++)
            {
                Assert.Equal(nums[i], expectedUniqueValues[i]);
            }
        }
    }
}
