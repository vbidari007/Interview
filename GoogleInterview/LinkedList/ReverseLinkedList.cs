﻿using System;
namespace LinkedList
{
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            while(curr!=null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }

            return prev;
        }
    }
}
