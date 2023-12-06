using LeetCodeTraining.LongestCommonPrefix;

namespace LeetCodeTraining.Tests
{
    public class LongestCommonPrefixSolutionTest
    {
        [Theory]
        [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new string[] { "dog", "racecar", "car" }, "")]
        [InlineData(new string[] { "cow", "co-worker", "commit" }, "co")]
        public void LongestCommonPrefix(string[] strs, string expectedResult)
        {
            //Act
            string result = LongestCommonPrefixSolution.LongestCommonPrefix(strs);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
