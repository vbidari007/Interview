using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class IntersectionNode
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();

            while(headA!=null && headB!=null)
            {
                if (set.Contains(headA))
                    return headA;
                else
                    set.Add(headA);
                if (set.Contains(headB))
                    return headB;
                else
                    set.Add(headB);
            }

            return null;
        }
        public ListNode GetIntersectionNode2(ListNode headA, ListNode headB)
        {
            ListNode p1 = headA, p2 = headB;

            while(p1!=p2)
            {
                p1 = p1 == null ? headB : p1.next;
                p2 = p2 == null ? headA : p2.next;
            }

            return p1;
        }
    }
}
