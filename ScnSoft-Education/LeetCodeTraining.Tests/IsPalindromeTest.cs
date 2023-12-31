﻿using LeetCodeTraining.IsPalindrome1;

namespace LeetCodeTraining.Tests
{
    public class IsPalindromeSolutionTest
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        public void IsPalindrome(int x, bool expectedResult)
        {
            //Act
            bool result = PalindromeSolution.IsPalindrome(x);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
