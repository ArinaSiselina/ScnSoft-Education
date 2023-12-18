using LeetCodeTraining.ValidParentheses;

namespace LeetCodeTraining.Tests
{
    public class ValidParenthesesSolutionTest
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        public void IsValid(string s, bool expectedResult)
        {
            //Act
            bool result = ValidParenthesesSolution.IsValid(s);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
