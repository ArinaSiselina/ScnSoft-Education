using LeetCodeTraining.DivideTwoIntegers;

namespace LeetCodeTraining.Tests
{
    public class DivideTwoIntegersSolutionTest
    {
        [Theory]
        [InlineData(10, 3, 3)]
        [InlineData(7, -3, -2)]
        public void DivideTwoIntegers(int dividend, int divisor, int expectedResult)
        {
            //Act
            int result = DivideTwoIntegersSolution.Divide(dividend, divisor);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}