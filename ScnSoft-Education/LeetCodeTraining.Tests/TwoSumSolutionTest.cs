using LeetCodeTraining.TwoSum1;
namespace LeetCodeTraining.Tests
{
    public class TwoSumSolutionTest
    {
        [Fact]
        public void TwoSumArrayWith2Nums()
        {
            //Arrange1
            int[] nums = new int[] { 2,7,11,15 };
            int target = 9;
            int[] expectedResults = new int[] { 0, 1 };
            //Arrange2
            int[] nums1 = new int[] { 3, 2, 4 };
            int target1 = 6;
            int[] expectedResults1 = new int[] { 1, 2 };
            //Arrange3
            int[] nums2 = new int[] { 3, 3 };
            int target2 = 6;
            int[] expectedResults2 = new int[] { 0, 1 };
            //Act1
            int[] Result = TwoSumSolution.TwoSum(nums, target);
            //Act2
            int[] Result1 = TwoSumSolution.TwoSum(nums1, target1);
            //Act3
            int[] Result2 = TwoSumSolution.TwoSum(nums2, target2);
            //Assert1
            Assert.Equal(expectedResults.Length, Result.Length);
            Array.Sort(Result);
            for (int i = 0; i < expectedResults.Length; i++)
            {
                Assert.Equal(expectedResults[i], Result[i]);
            }
            //Assert2
            Assert.Equal(expectedResults1.Length, Result1.Length);
            Array.Sort(Result1);
            for (int i = 0; i < expectedResults1.Length; i++)
            {
                Assert.Equal(expectedResults1[i], Result1[i]);
            }
            //Assert3
            Assert.Equal(expectedResults2.Length, Result2.Length);
            Array.Sort(Result2);
            for (int i = 0; i < expectedResults2.Length; i++)
            {
                Assert.Equal(expectedResults2[i], Result2[i]);
            } 
        }
    }
}
