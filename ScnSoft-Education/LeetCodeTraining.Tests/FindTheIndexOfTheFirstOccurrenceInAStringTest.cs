using LeetCodeTraining.FindTheIndexOfTheFirstOccurrenceInAString;

namespace LeetCodeTraining.Tests
{
    public class FindTheIndexOfTheFirstOccurrenceInAStringSolutionTest
    {
        [Theory]
        [InlineData("sadbutsad", "sad", 0)]
        [InlineData("leetcode", "leeto", -1)]
        public void FindTheIndexOfTheFirstOccurrenceInAString(string haystack, string needle, int expectedResult)
        {
            //Act
            int result = FindTheIndexOfTheFirstOccurrenceInAStringSolution.StrStr(haystack, needle);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}