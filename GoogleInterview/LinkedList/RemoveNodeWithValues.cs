using System;
namespace LinkedList
{
    public class RemoveNodeWithValues
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
           

            while( head!=null && head.val == val )
            {
                head = head.next;
            }

            if (head == null)
                return null;

            
            var prev = head;
            var cur = head.next;
            while (cur!=null)
            {
                if(cur.val==val)
                {
                    prev.next = cur.next;

                }
                prev = prev.next;
                cur = cur.next;
            }

            return head;
        }
    }
}
