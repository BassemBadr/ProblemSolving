#nullable disable

using ProblemSolving;

namespace ProblemSolving.LeetCode.Types
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x = 0, ListNode next = null)
        {
            val = x;
            next = null;
        }

        public static bool AreNonCyclicListsEqual(ListNode head1, ListNode head2)
        {
            while (head1 != null && head2 != null)
            {
                if (head1.val != head2.val)
                    return false;
                head1 = head1.next;
                head2 = head2.next;
            }

            // Both should be null at the end
            return head1 == null && head2 == null;
        }
    }
}
