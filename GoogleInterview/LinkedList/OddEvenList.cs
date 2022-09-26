using System;
namespace LinkedList
{
    public class OddEvenList1
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null) return null;
            ListNode odd = head, even = head.next, evenHead = even;

            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }
            odd.next = evenHead;
            return head;
        }
    }
}
