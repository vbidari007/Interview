using System;
namespace LinkedList
{
    public class Palindrome
    {
        ListNode frontPointer;

        public bool CheckPalindrome(ListNode currentNode)
        {
            if(currentNode!=null)
            {
                if (!CheckPalindrome(currentNode.next))
                    return false;
                if (currentNode.val != frontPointer.val)
                    return false;
                frontPointer = frontPointer.next;
            }
            return true;
        }
        public bool IsPalindrome(ListNode head)
        {
            frontPointer = head;
            return CheckPalindrome(head);
        }
    }
}
