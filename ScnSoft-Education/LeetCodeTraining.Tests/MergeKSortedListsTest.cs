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
            var result = MergeKSortedListsSolution.MergeKLists(input);

            // Assert
            Assert.Equal(expected, result);
        }

        public static TheoryData<ListNode[], ListNode> TestData =>
            new TheoryData<ListNode[], ListNode>
            {
                {
                    new ListNode[]
                    {
                        new ListNode(1, new ListNode(4, new ListNode(5))),
                        new ListNode(1, new ListNode(3, new ListNode(4))),
                        new ListNode(2, new ListNode(6))
                    },
                    new ListNode(1, new ListNode(1, new ListNode(2,new ListNode(3, new ListNode(4,new ListNode(4, new ListNode(5, new ListNode(6))))))))
                },
                { new ListNode[] { }, null},
                { new ListNode[] { new ListNode() }, new ListNode()}
            };
    }
}


