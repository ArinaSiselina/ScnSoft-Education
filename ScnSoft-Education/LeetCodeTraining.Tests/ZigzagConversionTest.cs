using LeetCodeTraining.ZigzagConversion;

namespace LeetCodeTraining.Tests
{
    public class ZigzagConversionSolutionTest
    {
        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [InlineData("A", 1, "A")]
        public void ZigzagConversion(string s, int numRows, string expectedResult)
        {
            //Act
            string result = ZigzagConversionSolution.Convert(s, numRows);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}