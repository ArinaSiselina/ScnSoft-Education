using LeetCodeTraining.NextPermutation;

namespace LeetCodeTraining.Tests
{
    public class NextPermutationSolutionTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 3, 2 })]
        [InlineData(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 1, 1, 5 }, new int[] { 1, 5, 1 })]
        public void NextPermutation(int[] input, int[] expectedResult)
        {
            // Arrange
            NextPermutationSolution solution = new NextPermutationSolution();
            //int[] inputCopy = (int[])input.Clone();

            // Act
            solution.NextPermutation(input);

            // Assert
            Assert.Equal(expectedResult, input);
        }
        
    }
}