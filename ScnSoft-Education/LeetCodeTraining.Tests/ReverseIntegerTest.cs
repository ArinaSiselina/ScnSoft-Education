using LeetCodeTraining.ReverseInteger;

namespace LeetCodeTraining.Tests
{
    public class ReverseIntegerSolutionTest
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        public void ReverseInteger(int x, int expectedResult)
        {
            //Act
            int Result = ReverseIntegerSolution.Reverse(x);

            //Assert
            Assert.Equal(expectedResult, Result);
        }
    }
}
