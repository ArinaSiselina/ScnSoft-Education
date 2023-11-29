
namespace LeetCodeTraining.AddTwoNumbers
{
    // https://leetcode.com/problems/string-to-integer-atoi/
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class AddTwoNumbersSolution
    { 
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            ListNode one = l1, two = l2, curr = result;
            int remember = 0;

            while (one != null || two != null)
            {
                int x = (one != null) ? one.val : 0;
                int y = (two != null) ? two.val : 0;

                int sum = remember + x + y;
                remember = sum / 10;

                curr.next = new ListNode(sum % 10);
                curr = curr.next;

                if (one != null) one = one.next;
                if (two != null) two = two.next;
            }

            if (remember > 0)
            {
                curr.next = new ListNode(remember);
            }

            return result.next;
        }
    }
}
