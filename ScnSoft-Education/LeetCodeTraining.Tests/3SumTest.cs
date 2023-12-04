using LeetCodeTraining.ThreeSum;

namespace LeetCodeTraining.Tests
{
    public class ThreeSumSolutionTest
    {
        [Theory]
        [InlineData("-1,0,1,2,-1,-4", "[-1,-1,2],[-1,0,1]")]
        [InlineData("0,1,1", "")]
        [InlineData("0,0,0", "0,0,0")]
        public void ThreeSum(string inputStr, string expectedStr)
        {
            int[] input = inputStr.Split(',').Select(int.Parse).ToArray();

            List<List<int>> expected = new List<List<int>>();
            if (!string.IsNullOrEmpty(expectedStr))
            {
                expected = expectedStr.Split(']')
                                      .Where(s => !string.IsNullOrWhiteSpace(s) && s != ",")
                                      .Select(s => s.Trim('[', ',')
                                      .Split(',')
                                      .Select(int.Parse)
                                      .ToList())
                                      .ToList();
            }

            //Act
            IList<IList<int>> result = ThreeSumSolution.ThreeSum(input);

            List<List<int>> resultList = new List<List<int>>();
            foreach (var list in result)
            {
                resultList.Add(list.OrderBy(x => x).ToList());
            }

            //Assert
            Assert.Equal(expected.OrderBy(list => string.Join(",", list)), resultList.OrderBy(list => string.Join(",", list)));
        }
    }
}






