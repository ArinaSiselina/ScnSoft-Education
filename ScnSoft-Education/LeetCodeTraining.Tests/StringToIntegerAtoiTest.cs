using LeetCodeTraining.StringToIntegerAtoi;

namespace LeetCodeTraining.Tests
{
    public class StringToIntegerAtoiSolutionTest
    {
        [Theory]
        [InlineData("42", 42)]
        [InlineData("   -42", -42)]
        [InlineData("4193 with words", 4193)]
        public void StringToIntegerAtoi(string s, int expectedResult)
        {
            //Act
            int Result = StringToIntegerAtoiSolution.MyAtoi(s);

            //Assert
            Assert.Equal(expectedResult, Result);
        }
    }
}
