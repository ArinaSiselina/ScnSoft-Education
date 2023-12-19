namespace LeetCodeTraining.SwapNodesInPairs
{
    //https://leetcode.com/problems/swap-nodes-in-pairs/
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

    public class SwapNodesInPairsSolution
    {
        public static ListNode SwapPairs(ListNode head)
        {
            ListNode result = new ListNode(0, head);
            ListNode current = result;

            while (current.next != null && current.next.next != null)
            {
                ListNode firstNode = current.next;
                ListNode secondNode = current.next.next;

                firstNode.next = secondNode.next;
                current.next = secondNode;
                secondNode.next = firstNode;
                current = secondNode.next;
            }

            return result.next;
        }
    }
}