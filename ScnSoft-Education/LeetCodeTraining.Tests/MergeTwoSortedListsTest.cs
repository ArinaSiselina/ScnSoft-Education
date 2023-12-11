using LeetCodeTraining.MergeTwoSortedLists;

namespace LeetCodeTraining.Tests
{
    public class MergeTwoSortedListsSolutionTests
    {
        [Theory]
        [MemberData(nameof(MergeTestData))]
        public void MergeTwoLists(ListNode list1, ListNode list2, ListNode expected)
        {
            // Act
            ListNode resultNode = MergeTwoSortedListsSolution.MergeTwoLists(list1, list2);

            // Assert
            Assert.Equal(expected.val, resultNode.val);
        }

        public static TheoryData<ListNode, ListNode, ListNode> MergeTestData()
        {
            return new TheoryData<ListNode, ListNode, ListNode>
            {
                {
                    new ListNode(new[] { 1, 2, 4 }),
                    new ListNode(new[] { 1, 3, 4 }),
                    new ListNode(new[] { 1, 1, 2, 3, 4, 4 })
                },
                {
                    new ListNode(new int[] { }),
                    new ListNode(new int[] { }),
                    new ListNode(new int[] { })
                },
                {
                    new ListNode(new int[] { }),
                    new ListNode(new[] { 0 }),
                    new ListNode(new[] { 0 })
                }
            };
        }
    }
}
