using LeetCodeTraining.ThreeSum;

namespace LeetCodeTraining.Tests
{
    public class ThreeSumSolutionTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void ThreeSumTest(int[] nums, IList<IList<int>> expectedResult)
        {
            // Act
            var result = ThreeSumSolution.ThreeSum(nums);

            // Assert
            Assert.Equal(expectedResult, result);

            for (int i = 0; i < result.Count; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[]
            {
                new int[] { -1, 0, 1, 2, -1, -4 },
                new List<IList<int>>
                {
                    new List<int> { -1, -1, 2 },
                    new List<int> { -1, 0, 1 }
                }
            },

            new object[]
            {
                new int[] { 0, 1, 1 },
                new List<IList<int>> { }
            },

            new object[]
            {
                new int[] { 0, 0, 0 },
                new List<IList<int>> { new List<int> { 0, 0, 0 } }
            }
        };
    }
}






