using LeetCodeTraining.ThreeSum;

namespace LeetCodeTraining.Tests
{
    public class ThreeSumSolutionTest
    {
        [Theory]
        [InlineData(new int[] { -1, 0, 1, 2, -1, -4 }, new int[][] { new int[] { -1, -1, 2 }, new int[] { -1, 0, 1 } })]
        [InlineData(new int[] { 0, 1, 1 }, false)]
        [InlineData(new int[] { 0, 0, 0 }, false)]
        public void ThreeSum(int[] nums, IList<IList<int>> expectedResult)
        {
            //Act
            IList<IList<int>> result = ThreeSumSolution.ThreeSum(nums);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}


