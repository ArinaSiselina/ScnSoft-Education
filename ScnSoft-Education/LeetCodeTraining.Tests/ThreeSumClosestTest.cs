using LeetCodeTraining.ThreeSumClosest;

namespace LeetCodeTraining.Tests
{
    public class ThreeSumClosestSolutionTest
    {
        [Theory]
        [InlineData(new int[] { -1, 2, 1, -4 }, 1, 2)]
        [InlineData(new int[] { 0, 0, 0 }, 1, 0)]
        public void ThreeSumClosest(int[] nums, int target, int expectedResult)
        {
            //Act
            int result = ThreeSumClosestSolution.ThreeSumClosest(nums, target);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
