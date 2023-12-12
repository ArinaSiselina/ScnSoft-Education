namespace LeetCodeTraining.MergeTwoSortedLists
{
    //https://leetcode.com/problems/merge-two-sorted-lists/
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ListNode(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return;
            }

            this.val = numbers[0];
            ListNode current = this;

            for (int i = 1; i < numbers.Length; i++)
            {
                current.next = new ListNode(numbers[i]);
                current = current.next;
            }
        }

        public override bool Equals(object? obj)
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
    }

    public class MergeTwoSortedListsSolution
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result = new ListNode();
            ListNode current = result;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }

                current = current.next;
            }

            current = (list1 != null) ? list1 : list2;

            return result.next;
        }
    }
}