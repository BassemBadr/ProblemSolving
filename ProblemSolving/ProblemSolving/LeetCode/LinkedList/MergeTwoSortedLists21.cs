using ProblemSolving.Types;

namespace ProblemSolving.LeetCode.LinkedList
{
    public class MergeTwoSortedLists21
    {
        //https://leetcode.com/problems/merge-two-sorted-lists
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            //  time O(m + n)
            //  space O(1) by reusing existing nodes

            ListNode dummy = new ListNode();
            ListNode current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
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

            current.next = list1 ?? list2;

            return dummy.next;
        }

        private static ListNode Solution1(ListNode list1, ListNode list2)
        {
            //  time O(m + n)
            //  space O(m + n)
            //  but solution should be made by splicing nodes from original lists
            ListNode resultHead = null, current = null, current1 = list1, current2 = list2;

            while (current1 != null || current2 != null)
            {
                ListNode temp = null;

                if (current1 != null && current2 != null)
                {
                    if (current1.val <= current2.val)
                    {
                        temp = current1;
                        current1 = current1.next;
                    }
                    else
                    {
                        temp = current2;
                        current2 = current2.next;
                    }
                }
                else if (current1 != null)
                {
                    temp = current1;
                    current1 = current1.next;
                }
                else if (current2 != null)
                {
                    temp = current2;
                    current2 = current2.next;
                }

                if (temp != null)
                {
                    if (resultHead == null)
                    {
                        resultHead = new ListNode(temp.val);
                        current = resultHead;
                    }
                    else
                    {
                        current.next = new ListNode(temp.val);
                        current = current.next;
                    }
                }
            }
            return resultHead;
        }
    }
}
