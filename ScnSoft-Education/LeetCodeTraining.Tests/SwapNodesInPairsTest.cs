using LeetCodeTraining.SwapNodesInPairs;

namespace LeetCodeTraining.Tests
{
    public class SwapNodesInPairsSolutionTest
    {
        private ListNode InitializeNode(int[] numbers)
        {
            if (numbers.Length==0) return null;
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
            if (node == null) return "";
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
        [InlineData(new int[] { 1, 2, 3, 4 }, "2143")]
        [InlineData(new int[] {}, "")]
        [InlineData(new int[] { 1 }, "1")]
        public void SwapNodesInPairs(int[] list1, string expectedResult)
        {
            //Arrange
            ListNode l1 = InitializeNode(list1);

            //Act
            ListNode resultNode = SwapNodesInPairsSolution.SwapPairs(l1);
            string result = DisplayNode(resultNode);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}