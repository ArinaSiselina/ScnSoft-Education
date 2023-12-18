using LeetCodeTraining.GenerateParentheses;

namespace LeetCodeTraining.Tests
{
    public class GenerateParenthesesSolutionTest
    {
        [Theory]
        [InlineData(3, new[] { "((()))", "(()())", "(())()", "()(())", "()()()" })]
        [InlineData(1, new[] { "()" })]
        [InlineData(2, new[] { "(())", "()()" })]
        public void GenerateParentheses(int n, string[] expected)
        {
            // Act
            IList<string> result = GenerateParenthesesSolution.GenerateParentheses(n);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}