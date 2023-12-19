using LeetCodeTraining.SortColors;

namespace LeetCodeTraining.Tests
{
    public class SortColorsSolutionTest
    {
        [Theory]
        [InlineData(new int[] { 2, 0, 2, 1, 1, 0 }, new int[] { 0, 0, 1, 1, 2, 2 })]
        [InlineData(new int[] { 2, 0, 1 }, new int[] { 0, 1, 2 })]
        public void SortColors(int[] input, int[] expected)
        {
            SortColorsSolution.SortColors(input);
            Assert.Equal(expected, input);
        }
    }
}
