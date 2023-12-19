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

        // Constructor to initialize ListNode with int array
        public ListNode(int[] values)
        {
            if (values == null || values.Length == 0)
            {
                return;
            }

            this.val = values[0];
            ListNode current = this;

            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }
        }

        // Override Equals to compare ListNode objects directly
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ListNode other = (ListNode)obj;
            ListNode currentThis = this;
            ListNode currentOther = other;

            while (currentThis != null && currentOther != null)
            {
                if (currentThis.val != currentOther.val)
                {
                    return false;
                }
                currentThis = currentThis.next;
                currentOther = currentOther.next;
            }

            return currentThis == null && currentOther == null;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
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

            return lists[0];
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

            current.next = l1 == null ? l2 : l1;

            return result.next;
        }
    }
}