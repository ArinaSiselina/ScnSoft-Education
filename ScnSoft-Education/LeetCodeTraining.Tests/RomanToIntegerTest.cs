using LeetCodeTraining.RomanToInteger;

namespace LeetCodeTraining.Tests
{
    public class RomanToIntegerSolutionTest
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void RomanToInt(string s, int expectedResult)
        {
            //Act
            int result = RomanToIntegerSolution.RomanToInt(s);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
