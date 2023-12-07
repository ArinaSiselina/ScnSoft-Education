using LeetCodeTraining.MergeTwoSortedLists;

namespace LeetCodeTraining.Tests
{
    public class MergeTwoSortedListsSolutionTests
    {
        public static ListNode InitializeNode(int[] numbers)
        {
            if (numbers.Length == 0)
                return null;

            ListNode head = new ListNode(numbers[0]);
            ListNode current = head;
            for (int i = 1; i < numbers.Length; i++)
            {
                current.next = new ListNode(numbers[i]);
                current = current.next;
            }
            return head;
        }

        public static bool CompareNodes(ListNode node1, ListNode node2)
        {
            while (node1 != null && node2 != null)
            {
                if (node1.val != node2.val)
                    return false;
                node1 = node1.next;
                node2 = node2.next;
            }
            return node1 == null && node2 == null;
        }

        [Theory]
        [InlineData(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 })]
        [InlineData(new int[] { }, new int[] { }, new int[] { })]
        [InlineData(new int[] { }, new int[] { 0 }, new[] { 0 })]
        public void MergeTwoLists(int[] list1, int[] list2, int[] expected)
        {
            // Arrange
            ListNode l1 = InitializeNode(list1);
            ListNode l2 = InitializeNode(list2);
            ListNode expectedNode = InitializeNode(expected);

            // Act
            ListNode resultNode = MergeTwoSortedListsSolution.MergeTwoLists(l1, l2);

            // Assert
            Assert.True(CompareNodes(expectedNode, resultNode));
        }
    }
}
