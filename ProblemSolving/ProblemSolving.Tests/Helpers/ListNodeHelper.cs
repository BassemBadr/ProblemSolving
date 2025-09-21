using ProblemSolving.Types;

namespace ProblemSolving.Tests.Helpers
{
    public class ListNodeHelper
    {
        public static ListNode CreateListNode(int[] nums, int pos = -1)
        {
            if (nums == null || nums.Length == 0)
                return null;

            ListNode[] nodes = new ListNode[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nodes[i] = new ListNode(nums[i]);
            }

            // Connect nodes in sequence
            for (int i = 0; i < nums.Length - 1; i++)
            {
                nodes[i].next = nodes[i + 1];
            }

            // Create cycle if pos is valid
            if (pos >= 0 && pos < nums.Length)
            {
                nodes[nums.Length - 1].next = nodes[pos];
            }

            return nodes[0];
        }

        public static ListNode CreateListNode2(int[] nums, int pos)
        {
            if (nums == null || nums.Length == 0)
                return null;

            ListNode head = new ListNode(nums[0]);
            ListNode current = head;
            ListNode cycleNode = (pos == 0) ? head : null;

            // Create nodes and track cycle node
            for (int i = 1; i < nums.Length; i++)
            {
                current.next = new ListNode(nums[i]);
                current = current.next;

                if (i == pos)
                {
                    cycleNode = current;
                }
            }

            // Create cycle if pos is valid
            if (pos >= 0 && pos < nums.Length)
            {
                current.next = cycleNode;
            }

            return head;
        }
    }
}
