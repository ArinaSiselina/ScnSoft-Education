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

    public class ListNodeComparer : IComparer<ListNode>
    {
        public int Compare(ListNode x, ListNode y)
        {
            return x.val.CompareTo(y.val);
        }
    }

    public class MergeKSortedListsSolution
    {
        public static ListNode MergeKLists(ListNode[] lists)
        {
            PriorityQueue<ListNode> q = new PriorityQueue<ListNode>(new ListNodeComparer());

            foreach (var l in lists)
            {
                if (l != null)
                {
                    q.Enqueue(l);
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
                    q.Enqueue(node.next);
                }
            }

            return result.next;
        }
    }

    public class PriorityQueue<T>
    {
        private List<T> data;
        private IComparer<T> comparer;

        public PriorityQueue(IComparer<T> comparer)
        {
            this.data = new List<T>();
            this.comparer = comparer;
        }

        public int Count
        {
            get { return data.Count; }
        }

        public void Enqueue(T item)
        {
            data.Add(item);
            int childIndex = data.Count - 1;
            while (childIndex > 0)
            {
                int parentIndex = (childIndex - 1) / 2;
                if (comparer.Compare(data[childIndex], data[parentIndex]) >= 0)
                    break;

                T tmp = data[childIndex];
                data[childIndex] = data[parentIndex];
                data[parentIndex] = tmp;
                childIndex = parentIndex;
            }
        }

        public T Dequeue()
        {
            if (data.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            int lastIndex = data.Count - 1;
            T frontItem = data[0];
            data[0] = data[lastIndex];
            data.RemoveAt(lastIndex);

            lastIndex--;

            int parentIndex = 0;
            while (true)
            {
                int leftChildIndex = 2 * parentIndex + 1;
                if (leftChildIndex > lastIndex)
                    break;

                int rightChildIndex = leftChildIndex + 1;
                if (rightChildIndex <= lastIndex && comparer.Compare(data[rightChildIndex], data[leftChildIndex]) < 0)
                    leftChildIndex = rightChildIndex;

                if (comparer.Compare(data[parentIndex], data[leftChildIndex]) <= 0)
                    break;

                T tmp = data[parentIndex];
                data[parentIndex] = data[leftChildIndex];
                data[leftChildIndex] = tmp;
                parentIndex = leftChildIndex;
            }

            return frontItem;
        }
    }
}