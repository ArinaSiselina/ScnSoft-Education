using LeetCodeTraining.RemoveElement;

namespace LeetCodeTraining.Tests
{
    public class RemoveElementSolutionTest
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2)]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
        public void RemoveElement(int[] nums, int val, int expectedResult)
        {
            //Act
            int result = RemoveElementSolution.RemoveElement(nums, val);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
