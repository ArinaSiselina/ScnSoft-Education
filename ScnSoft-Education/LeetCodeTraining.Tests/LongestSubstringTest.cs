using LeetCodeTraining.LongestSubstring1;

namespace LeetCodeTraining.Tests
{
    public class LongestSubstringSolutionTest
    {
        [Fact]
        public void LongestSubstring()
        {
            //Arrange
            string s1 = "abcabcbb";
            int expectedResults1 = 3;

            string s2 = "bbbbb";
            int expectedResults2 = 1;

            string s3 = "pwwkew";
            int expectedResults3 = 3;

            //Act
            int Result1 = SubstringSolution.LengthOfLongestSubstring(s1);
            int Result2 = SubstringSolution.LengthOfLongestSubstring(s2);
            int Result3 = SubstringSolution.LengthOfLongestSubstring(s3);

            //Assert
            Assert.Equal(expectedResults1, Result1);
            Assert.Equal(expectedResults2, Result2);
            Assert.Equal(expectedResults3, Result3);
        }
    }
}