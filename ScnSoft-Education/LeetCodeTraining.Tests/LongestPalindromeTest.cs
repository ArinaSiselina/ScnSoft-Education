using LeetCodeTraining.LongestPalindrome;

namespace LeetCodeTraining.Tests
{
    public class longestPalindromeSolutionTest
    {
        [Theory]
        [InlineData("babad", "aba")]
        [InlineData("cbbd", "bb")]
        [InlineData("fghjklkj", "jklkj")]
        public void LongestPalindrome(string s, string expectedResult)
        {
            //Act
            string Result = LongestPalindromeSolution.LongestPalindrome(s);

            //Assert
            Assert.Equal(expectedResult, Result);
        }
    }
}