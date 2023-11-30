using LeetCodeTraining.AddTwoNumbers;

namespace LeetCodeTraining.Tests
{
    public class AddTwoNumbersSolutionTest
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
            [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, "708")]
            [InlineData(new int[] { 0 }, new int[] { 0 }, "0")]
            [InlineData(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, "89990001")]
            public void AddNumbers(int[] list1, int[] list2, string expectedResult)
            {
                //Arrange
                ListNode l1 = InitializeNode(list1);
                ListNode l2 = InitializeNode(list2);

                //Act
                ListNode resultNode = AddTwoNumbersSolution.AddTwoNumbers(l1, l2);
                string result = DisplayNode(resultNode);

                //Assert
                Assert.Equal(expectedResult, result);
            }
        }
    }

