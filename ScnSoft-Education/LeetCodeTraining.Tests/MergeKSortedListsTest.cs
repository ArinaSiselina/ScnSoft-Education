using LeetCodeTraining.MergeKSortedLists;

namespace LeetCodeTraining.Tests
{
    public class MergeKSortedListsSolutionTest
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void MergeKLists(ListNode[] input, ListNode expected)
        {
            // Act
            ListNode result = MergeKSortedListsSolution.MergeKLists(input);

            // Assert
            Assert.Equal(expected, result);
        }

        public static TheoryData<ListNode[], ListNode> TestData =>
            new TheoryData<ListNode[], ListNode>
            {
                {
                    new ListNode[]
                    {
                        new ListNode(new[] { 1, 4, 5 }),
                        new ListNode(new[] { 1, 3, 4 }),
                        new ListNode(new[] { 2, 6 })
                    },
                    new ListNode(new[] { 1, 1, 2, 3, 4, 4, 5, 6 })
                },
                { new ListNode[] { }, null},
                { new ListNode[] { new ListNode() }, new ListNode()}
            };
    }
}


