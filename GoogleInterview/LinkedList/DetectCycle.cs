using System;
namespace LinkedList
{
    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
    public class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            var slow = head;
            var fast = head;

            // Find meeting point
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    break;
                }
            }

            // Error check - there is no meeting point, and therefore no loop
            if (fast == null || fast.next == null)
            {
                return null;
            }

            /* Move slow to Head. Keep fast at Meeting Point. Each are k steps
            /* from the Loop Start. If they move at the same pace, they must
             * meet at Loop Start. */
            slow = head;
            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }

            // Both now point to the start of the loop.
            return fast;

        }
    }
}
