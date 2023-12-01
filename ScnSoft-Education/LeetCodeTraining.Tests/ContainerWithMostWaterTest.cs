using LeetCodeTraining.ContainerWithMostWater;

namespace LeetCodeTraining.Tests
{
    public class ContainerWithMostWaterSolutionTest
    {
        [Theory]
        [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [InlineData(new int[] { 1, 1 }, 1)]
        [InlineData(new int[] { 4, 3, 2, 1, 4 }, 16)]
        public void MaxArea(int[] height, int expectedResult)
        {
            //Act
            int result = ContainerWithMostWaterSolution.MaxArea(height);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
