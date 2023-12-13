using LeetCodeTraining.RemoveDuplicatesFromSortedArray;

namespace LeetCodeTraining.Tests
{
    public class RemoveDuplicatesFromSortedArraySolutionTest
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, 2)]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        public void RemoveDuplicatesFromSortedArray(int[] nums, int expectedResult)
        {
            //Act
            int result = RemoveDuplicatesFromSortedArraySolution.RemoveDuplicates(nums);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
