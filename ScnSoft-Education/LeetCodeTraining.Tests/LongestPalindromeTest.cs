using LeetCodeTraining.LongestPalindrome;

namespace LeetCodeTraining.Tests
{
    public class LongestPalindromeSolutionTest
    {
        [Theory]
        [InlineData("babad", "aba")]
        [InlineData("cbbd", "bb")]
        [InlineData("fghjklkj", "jklkj")]
        public void LongestPalindrome(string s, string expectedResult)
        {
            //Act
            string result = LongestPalindromeSolution.LongestPalindrome(s);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
