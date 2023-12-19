using LeetCodeTraining.RegularExpressionMatching;

namespace LeetCodeTraining.Tests
{
    public class RegularExpressionMatchingSolutionTest
    {
        [Theory]
        [InlineData("aa", "a", false)]
        [InlineData("aa", "a*", true)]
        [InlineData("ab", ".*", true)]
        public void IsMatch(string s, string p, bool expectedResult)
        {
            //Act
            bool result = RegularExpressionMatchingSolution.IsMatch(s,p);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}