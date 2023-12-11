using LeetCodeTraining.FourSum;

namespace LeetCodeTraining.Tests
{
    public class FourSumSolutionTests
    {
        public static IEnumerable<object[]> FourSumTestCases()
        {
            yield return new object[]
            {
                new int[] { 1, 0, -1, 0, -2, 2 },
                0,
                new List<IList<int>>
                {
                    new List<int> { -2, -1, 1, 2 },
                    new List<int> { -2, 0, 0, 2 },
                    new List<int> { -1, 0, 0, 1 }
                }
            };

            yield return new object[]
            {
                new int[] { 2, 2, 2, 2, 2 },
                8,
                new List<IList<int>> { new List<int> { 2, 2, 2, 2 } }
            };
        }

        [Theory]
        [MemberData(nameof(FourSumTestCases))]
        public void FourSum(int[] nums, int target, List<IList<int>> expected)
        {
            // Act
            var result = FourSumSolution.FourSum(nums, target);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}