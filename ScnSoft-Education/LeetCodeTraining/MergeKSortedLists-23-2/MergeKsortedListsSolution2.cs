﻿namespace LeetCodeTraining.MergeKSortedLists2
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

    public class MergeKSortedListsSolution2
    {
        public static ListNode MergeKLists(ListNode[] lists)
        {
            PriorityQueue<ListNode, int> q = new PriorityQueue<ListNode, int>();

            foreach (var l in lists)
            {
                if (l != null)
                {
                    q.Enqueue(l, l.val);
                }
            }

            ListNode result = new ListNode(0);
            ListNode current = result;

            while (q.Count > 0)
            {
                var node = q.Dequeue();
                current.next = new ListNode(node.val);
                current = current.next;

                if (node.next != null)
                {
                    q.Enqueue(node.next, node.next.val);
                }
            }

            return result.next;
        }
    }
}