using LeetCodeTraining.AddTwoNumbers;

namespace LeetCodeTraining.Tests
{
    public class AddTwoNumbersSolutionTest
    {

        [Fact]
        public void AddTwoNumbers1()
        {
            // Arrange
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            // Act
            ListNode result = AddTwoNumbersSolution.AddTwoNumbers(l1, l2);

            // Assert
            Assert.Equal(7, result.val);
            Assert.Equal(0, result.next.val);
            Assert.Equal(8, result.next.next.val);
        }

        [Fact]
        public void AddTwoNumbers2()
        {
            // Arrange
            ListNode l1 = new ListNode(0);
            ListNode l2 = new ListNode(0);

            // Act
            ListNode result = AddTwoNumbersSolution.AddTwoNumbers(l1, l2);

            // Assert
            Assert.Equal(0, result.val);
        }

        [Fact]
        public void AddTwoNumbers3()
        {
            // Arrange
            ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));

            // Act
            ListNode result = AddTwoNumbersSolution.AddTwoNumbers(l1, l2);

            // Assert [8,9,9,9,0,0,0,1]
            Assert.Equal(8, result.val);
            Assert.Equal(9, result.next.val);
            Assert.Equal(9, result.next.next.val);
            Assert.Equal(9, result.next.next.next.val);
            Assert.Equal(0, result.next.next.next.next.val);
            Assert.Equal(0, result.next.next.next.next.next.val);
            Assert.Equal(0, result.next.next.next.next.next.next.val);
            Assert.Equal(1, result.next.next.next.next.next.next.next.val);
        }

    }
}