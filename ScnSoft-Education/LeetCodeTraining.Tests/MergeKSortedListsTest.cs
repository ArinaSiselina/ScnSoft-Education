using LeetCodeTraining.MergeKSortedLists;

namespace LeetCodeTraining.Tests
{
    public class MergeKSortedListsSolutionTest
    {
        [Fact]
        public void MergeKLists()
        {
            // Arrange
            ListNode list1 = new ListNode(1, new ListNode(4, new ListNode(5)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            ListNode list3 = new ListNode(2, new ListNode(6));

            ListNode[] lists = new ListNode[] { list1, list2, list3 };

            // Act
            ListNode result = MergeKSortedListsSolution.MergeKLists(lists);

            // Assert
            int[] expected = { 1, 1, 2, 3, 4, 4, 5, 6 };
            int[] actual = ConvertListNodeToArray(result);
            Assert.Equal(expected, actual);
        }

        private int[] ConvertListNodeToArray(ListNode listNode)
        {
            List<int> result = new List<int>();
            ListNode current = listNode;
            while (current != null)
            {
                result.Add(current.val);
                current = current.next;
            }
            return result.ToArray();
        }
    }
}


