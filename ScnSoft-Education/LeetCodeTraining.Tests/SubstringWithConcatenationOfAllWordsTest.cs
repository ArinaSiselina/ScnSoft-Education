using LeetCodeTraining.SubstringWithConcatenationOfAllWords;

namespace LeetCodeTraining.Tests
{
    public class SubstringWithConcatenationOfAllWordsSolutionTest
    {
        [Theory]
        [InlineData("barfoothefoobarman", new string[] { "foo", "bar" }, new int[] { 0, 9 })]
        [InlineData("wordgoodgoodgoodbestword", new string[] { "word", "good", "best", "word" }, new int[] { })]
        [InlineData("barfoofoobarthefoobarman", new string[] { "bar", "foo", "the" }, new int[] { 6, 9, 12 })]
        public void FindSubstring_ShouldReturnCorrectIndices(string s, string[] words, int[] expectedIndices)
        {
            // Act
            var result = SubstringWithConcatenationOfAllWordsSolution.FindSubstring(s, words).OrderBy(i => i).ToArray();

            // Assert
            Assert.Equal(expectedIndices, result);
        }
    }
}