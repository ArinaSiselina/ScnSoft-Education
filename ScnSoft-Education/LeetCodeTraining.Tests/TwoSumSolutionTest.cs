using LeetCodeTraining.TwoSum1;

namespace LeetCodeTraining.Tests
{
    public class TwoSumSolutionTest
    {
        [Fact]
      
            public void TwoSumArrayWith2Nums()
            {

                var nums = new int[] { 1, 2 };
                int target = 3;
                var expectedResults = new int[] { 0, 1 };

                var Result = TwoSumSolution.TwoSum(nums, target);

                Assert.Equal(expectedResults.Length, Result.Length);
                Array.Sort(Result);

                for (var i = 0; i < expectedResults.Length; i++)
                {
                    Assert.Equal(expectedResults[i], Result[i]);
                }
            }
        }
    } 
