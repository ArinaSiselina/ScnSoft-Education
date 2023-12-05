using LeetCodeTraining.ThreeSum;

namespace LeetCodeTraining.Tests
{
    public class ThreeSumSolutionTest
    {
        /*[Theory]
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
        }*/
     
        public class ThreeSumSolutionTests
        {
            [Theory]
            [MemberData(nameof(Data))]
            public void ThreeSumTest(int[] nums, IList<IList<int>> expectedResult)
            {
                // Arrange
                var solution = new ThreeSumSolution();

                // Act
                var result = ThreeSumSolution.ThreeSum(nums);

                // Assert
                Assert.Equal(expectedResult.Count, result.Count);
                for (int i = 0; i < result.Count; i++)
                {
                    Assert.Equal(expectedResult[i], result[i]);
                }
            }

            public static IEnumerable<object[]> Data =>
                new List<object[]>
                {
                new object[]
                {
                    new int[] { -1, 0, 1, 2, -1, -4 },
                    new List<IList<int>>
                    {
                        new List<int> { -1, -1, 2 },
                        new List<int> { -1, 0, 1 }
                    }
                },
                new object[]
                {
                    new int[] { 0, 1, 1 },
                    new List<IList<int>> { }
                },
                new object[]
                {
                    new int[] { 0, 0, 0 },
                    new List<IList<int>> { new List<int> { 0, 0, 0 } }
                }
                // Add more test cases here as needed
                };


        }
    }
}






