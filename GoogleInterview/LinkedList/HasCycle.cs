using System;
namespace LinkedList
{
    /**
 * Definition for singly-linked list.
 **/
 public class ListNode {
     public int val;
      public ListNode next;
      public ListNode(int x) {
          val = x;
          next = null;
      }
  }
 
    public class Solution1
    {
        public bool HasCycle(ListNode head)
        {
           
            if (head == null || head.next==null)
                return false;
            if (head.next == head)
                return true;
            var slow = head;
            var fast = head.next.next;
            while(fast!=null && slow!=fast && fast.next!=null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            if (slow == fast)
                return true;
            else
                return false;
        }
    }
}
