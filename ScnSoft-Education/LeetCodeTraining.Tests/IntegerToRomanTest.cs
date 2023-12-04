using LeetCodeTraining.IntegerToRoman;

namespace LeetCodeTraining.Tests
{
    public class IntegerToRomanSolutionTest
    {
        [Theory]
        [InlineData(3, "III")]
        [InlineData(58, "LVIII")]
        [InlineData(1994, "MCMXCIV")]
        public void IntegerToRoman(int num, string expectedResult)
        {
            //Act
            string result = IntegerToRomanSolution.IntToRoman(num);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
