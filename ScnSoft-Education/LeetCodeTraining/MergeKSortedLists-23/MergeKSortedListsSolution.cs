namespace LeetCodeTraining.MergeKSortedLists
{
    //https://leetcode.com/problems/merge-k-sorted-lists/
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

    public class MergeKSortedListsSolution
    {
        public static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0)
                return null;

            int interval = 1;
            while (interval < lists.Length)
            {
                for (int i = 0; i + interval < lists.Length; i += interval * 2)
                {
                    lists[i] = MergeTwoLists(lists[i], lists[i + interval]);
                }
                interval *= 2;
            }

            return lists.Length > 0 ? lists[0] : null;
        }

        private static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(-1);
            ListNode current = result;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }

            if (l1 != null)
            {
                current.next = l1;
            }
            else if (l2 != null)
            {
                current.next = l2;
            }

            return result.next;
        }
    }
}