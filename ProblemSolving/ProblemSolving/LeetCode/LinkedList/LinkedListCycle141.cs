namespace ProblemSolving.LeetCode.LinkedList
{
    public class LinkedListCycle141
    {
        //https://leetcode.com/problems/linked-list-cycle
        public bool HasCycle(ListNode head)
        {
            return Solution1(head);
        }

        private static bool Solution2(ListNode head)
        {
            //  time O(n)
            //  space O(n)
            if (head == null) return false;

            HashSet<ListNode> visited = [];
            ListNode current = head.next;
            visited.Add(head);
            while (current != null)
            {
                if (visited.Contains(current)) return true;

                visited.Add(current);

                current = current.next;
            }
            return false;
        }

        private static bool Solution1(ListNode head)
        {
            //  Floyd's Hare and Tortoise 
            //  Time O(n + k) k is cycle length if has cycle
            //  space O(1)
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                    return true;
            }
            return false;
        }
    }    
}
