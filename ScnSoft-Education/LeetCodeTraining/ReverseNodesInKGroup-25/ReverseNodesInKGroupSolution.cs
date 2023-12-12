namespace LeetCodeTraining.ReverseNodesInKGroup
{
    //https://leetcode.com/problems/reverse-nodes-in-k-group/
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

    public class ReverseNodesInKGroupSolution
    {
        public static ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode result = new ListNode(0);
            result.next = head;

            ListNode prev = result;
            ListNode end = result;

            while (end.next != null)
            {
                for (int i = 0; i < k && end != null; i++)
                {
                    end = end.next;
                }

                if (end == null)
                {
                    break;
                }

                ListNode start = prev.next;
                ListNode next = end.next;
                end.next = null;
                prev.next = ReverseList(start);
                start.next = next;

                prev = start;
                end = prev;
            }

            return result.next;
        }

        private static ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;

            while (curr != null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }

            return prev;
        }
    }
}