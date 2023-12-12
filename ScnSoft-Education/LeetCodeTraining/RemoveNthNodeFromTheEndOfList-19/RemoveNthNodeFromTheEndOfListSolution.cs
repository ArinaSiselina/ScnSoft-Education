namespace LeetCodeTraining.RemoveNthNodeFromEndOfList
{
    //https://leetcode.com/problems/remove-nth-node-from-end-of-list/
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

    public class RemoveNthNodeFromEndOfListSolution
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode result = new ListNode();
            result.next = head;

            ListNode first = result;
            ListNode second = result;

            for (int i = 1; i <= n + 1; i++)
            {
                first = first.next;
            }

            while (first != null)
            {
                first = first.next;
                second = second.next;
            }

            second.next = second.next.next;

            return result.next;
        }
    }
}