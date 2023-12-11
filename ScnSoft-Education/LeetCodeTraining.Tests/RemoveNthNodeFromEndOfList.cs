using LeetCodeTraining.RemoveNthNodeFromEndOfList;

namespace LeetCodeTraining.Tests
{
    public class RemoveNthNodeFromEndOfListSolutionTest
    {
        private ListNode InitializeNode(int[] numbers)
        {
            ListNode head = new ListNode(numbers[0]);
            ListNode current = head;

            for (int i = 1; i < numbers.Length; i++)
            {
                current.next = new ListNode(numbers[i]);
                current = current.next;
            }

            return head;
        }

        private string DisplayNode(ListNode node)
        {
            ListNode current = node;
            string result = "";

            while (current != null)
            {
                result += current.val;
                current = current.next;
            }

            return result;
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, "1235")]
        [InlineData(new int[] { 1 }, 1, "")]
        [InlineData(new int[] { 1, 2 }, 1, "1")]
        public void AddNumbers(int[] head, int n, string expectedResult)
        {
            //Arrange
            ListNode l1 = InitializeNode(head);

            //Act
            ListNode resultNode = RemoveNthNodeFromEndOfListSolution.RemoveNthFromEnd(l1, n);
            string result = DisplayNode(resultNode);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}