using LeetCodeTraining.LongestSubstring1;

namespace LeetCodeTraining.Tests
{
    public class LongestSubstringSolutionTest
    {
        [Theory]
        [InlineData("abcabcbb",3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        public void LongestSubstring(string s,int expectedResults)
        {
            int Result = SubstringSolution.LengthOfLongestSubstring(s);
            Assert.Equal(expectedResults, Result);
        }
    }
}
