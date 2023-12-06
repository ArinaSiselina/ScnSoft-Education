using LeetCodeTraining.FourSum;

namespace LeetCodeTraining.Tests
{
    public class FourSumSolutionTests
    {
        public static IEnumerable<object[]> FourSumTestCases()
        {
            yield return new object[]
            {
                new int[] { 1, 0, -1, 0, -2, 2 }, 0,
                new int[][] { new int[] { -2, -1, 1, 2 }, new int[] { -2, 0, 0, 2 }, new int[] { -1, 0, 0, 1 } }
            };

            yield return new object[]
            {
                new int[] { 2, 2, 2, 2, 2 }, 8,
                new int[][] { new int[] { 2, 2, 2, 2 } }
            };
        }

        [Theory]
        [MemberData(nameof(FourSumTestCases))]
        public void FourSum_ShouldReturnCorrectResult(int[] nums, int target, int[][] expected)
        {
            // Act
            var result = FourSumSolution.FourSum(nums, target);

            // Assert
            Assert.Equal(expected.Length, result.Count);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i].Length, result[i].Count);
                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.Equal(expected[i][j], result[i][j]);
                }
            }
        }
    }
}