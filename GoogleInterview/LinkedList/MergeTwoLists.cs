using System;
namespace LinkedList
{
    public class MergeTwoListsSolution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var ptr1 = list1;
            var ptr2 = list2;

            ListNode head = null;
            ListNode cur = null;

            while(ptr1!=null && ptr2!=null)
            {
                if(head==null)
                {
                    var temp = ptr1.val > ptr2.val ? ptr2 : ptr1;
                    ListNode node = new ListNode(temp.val);
                    head = node;
                    cur = head;
                    if(ptr1.val > ptr2.val)
                    {
                        ptr2 = ptr2.next;
                    }
                    else
                    {
                        ptr1 = ptr1.next;
                    }
                    continue;
                }
                if(ptr1.val < ptr2.val)
                {
                    var node = new ListNode(ptr1.val);
                    cur.next = node;
                    cur = node;
                    ptr1 = ptr1.next;
                    
                }
                else
                {
                    var node = new ListNode(ptr2.val);
                    cur.next = node;
                    cur = node;
                    ptr2 = ptr2.next;
                }


            }

            while(ptr1!=null)
            {
                var node = new ListNode(ptr1.val);
                cur.next = node;
                cur = node;
                ptr1 = ptr1.next;
            }
            while (ptr2 != null)
            {
                var node = new ListNode(ptr2.val);
                cur.next = node;
                cur = node;
                ptr2 = ptr2.next;
            }
            return head;
        }
    }
}
