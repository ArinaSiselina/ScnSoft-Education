using System.Threading;
using LeetCodeTraining.PrintInOrder;

namespace LeetCodeTraining.Tests
{
    public class PrintInOrderSolutionTests
    {
        [Theory]
        [InlineData(1, 2, 3, "first", "second", "third")]
        [InlineData(1, 3, 2, "first", "second", "third")]
        public void TestThreadOrder(int firstThreadId, int secondThreadId, int thirdThreadId,
                                    string expectedFirst, string expectedSecond, string expectedThird)
        {
            var foo = new Foo();
            var outputList = new List<string>();

            Action<string> printFirst = (output) => outputList.Add(output);
            Action<string> printSecond = (output) => outputList.Add(output);
            Action<string> printThird = (output) => outputList.Add(output);

            var threads = new Thread[3];
            threads[firstThreadId - 1] = new Thread(() => foo.First(() => printFirst(expectedFirst)));
            threads[secondThreadId - 1] = new Thread(() => foo.Second(() => printSecond(expectedSecond)));
            threads[thirdThreadId - 1] = new Thread(() => foo.Third(() => printThird(expectedThird)));

            foreach (var thread in threads)
            {
                thread.Start();
            }
            foreach (var thread in threads)
            {
                thread.Join();
            }

            Assert.Collection(outputList,
                item => Assert.Equal(expectedFirst, item),
                item => Assert.Equal(expectedSecond, item),
                item => Assert.Equal(expectedThird, item));
        }
    }
}