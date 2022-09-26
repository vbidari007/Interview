using System;
namespace LinkedList
{
    public class RemoveNthNode
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)
                return null;


            var cur = head;
            int cnt = 1;

            while(cur!=null && (cnt <=n ))
            {
                cur = cur.next;
                cnt++;
            }

            if (cur == null && cnt < n)
                return null;
            var ptr = head;
            ListNode prev = null;
            while (ptr != null && cur != null)
            {
                prev = ptr;
                ptr = ptr.next;
                cur = cur.next;
            }
            if (prev != null)
                prev.next = ptr.next;
            else
                head = null;
            return head;

        }
    }
}
