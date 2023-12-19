using LeetCodeTraining.ReverseNodesInKGroup;

namespace LeetCodeTraining.Tests
{
    public class ReverseNodesInKGroupSolutionTest
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
            string result = string.Empty;

            while (current != null)
            {
                result += current.val;
                current = current.next;
            }

            return result;
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, "21435")]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, "32145")]
        public void ReverseNodesInKGroup(int[] list1, int k, string expectedResult)
        {
            //Arrange
            ListNode l1 = InitializeNode(list1);

            //Act
            ListNode resultNode = ReverseNodesInKGroupSolution.ReverseKGroup(l1, k);
            string result = DisplayNode(resultNode);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}