using LeetCodeTraining.TwoSum1;

namespace LeetCodeTraining.Tests
{
    public class TwoSumSolutionTest
    {
        [Fact]
        public void TwoSumArrayWith2Nums()
        {
            //Arrange
            int[] nums1 = new int[] { 3, 2, 4 };
            int target1 = 6;
            int[] expectedResults1 = new int[] { 1, 2 };
            
            int[] nums2 = new int[] { 3, 3 };
            int target2 = 6;
            int[] expectedResults2 = new int[] { 0, 1 };
            
            int[] nums3 = new int[] { 2,7,11,15 };
            int target3 = 9;
            int[] expectedResults3 = new int[] { 0, 1 };
            
            //Act
            int[] Result1 = TwoSumSolution.TwoSum(nums1, target1);
            int[] Result2 = TwoSumSolution.TwoSum(nums2, target2);
            int[] Result3 = TwoSumSolution.TwoSum(nums3, target3);
            
            //Assert
            Assert.Equal(expectedResults1.Length, Result1.Length);
            Array.Sort(Result1);
            for (int i = 0; i < expectedResults1.Length; i++)
            {
                Assert.Equal(expectedResults1[i], Result1[i]);
            }
            
            Assert.Equal(expectedResults2.Length, Result2.Length);
            Array.Sort(Result2);
            for (int i = 0; i < expectedResults2.Length; i++)
            {
                Assert.Equal(expectedResults2[i], Result2[i]);
            }
            
            Assert.Equal(expectedResults3.Length, Result3.Length);
            Array.Sort(Result3);
            for (int i = 0; i < expectedResults3.Length; i++)
            {
                Assert.Equal(expectedResults3[i], Result3[i]);
            }
        }
    }
}
