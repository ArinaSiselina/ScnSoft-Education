using LeetCodeTraining.RemoveElement;

namespace LeetCodeTraining.Tests
{
    public class RemoveElementSolutionTest
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2, new int[] { 2, 2 })]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5, new int[] { 0, 1, 3, 0, 4 })]
        public void RemoveElement(int[] nums, int val, int expectedLength, int[] expectedArray)
        {
            // Act
            int resultLength = RemoveElementSolution.RemoveElement(nums, val);

            // Assert
            Assert.Equal(expectedLength, resultLength);

            for (int i = 0; i < resultLength; i++)
            {
                Assert.NotEqual(val, nums[i]);

                if (i < expectedArray.Length)
                {
                    Assert.Equal(expectedArray[i], nums[i]);
                }
            }
        }
    }
}
