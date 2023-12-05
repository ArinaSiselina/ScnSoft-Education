using LeetCodeTraining.LetterCombinationsOfAPhoneNumber;

namespace LeetCodeTraining.Tests
{
    public class LetterCombinationsOfAPhoneNumberTests
    {
        [Theory]
        [InlineData("2", new string[] { "a", "b", "c" })]
        [InlineData("23", new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
        [InlineData("", new string[] { })]
        public void LetterCombinations_ShouldReturnCorrectResult(string input, string[] expected)
        {
            // Act
            var result = LetterCombinationsOfAPhoneNumberSolution.LetterCombinations(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
