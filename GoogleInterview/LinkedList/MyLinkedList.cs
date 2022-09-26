using System;
namespace LinkedList
{
        public class LinkedListNode
        {
            public int Val { get; set; }

            public LinkedListNode Next { get; set; }
            public LinkedListNode Prev { get; set; }

            public LinkedListNode(int val, LinkedListNode next, LinkedListNode prev)
            {
                Val = val;
                Next = next;
                Prev = prev;
            }
        }
        public class MyLinkedList
        {
            public LinkedListNode Head { get; set; }

            public MyLinkedList()
            {
                Head = null;
            }

            public int Get(int index)
            {
                int idx = 0;
                var cur = Head;

                while(cur!=null && idx < index)
                {
                    cur = cur.Next;
                    idx++;
                }

                if (cur == null && idx <= index)
                    return -1;
                else
                    return cur.Val;
            }

            public void AddAtHead(int val)
            {
                if(Head==null)
                {
                    Head = new LinkedListNode(val, null, null);
                }
                else
                {
                    var temp = Head;
                    var node = new LinkedListNode(val, temp, null);
                    temp.Prev = node;
                    Head = node;
                }
           

            

            }

            public void AddAtTail(int val)
            {
                if(Head==null)
                {
                    Head = new LinkedListNode(val, null, null);
                    return;
                }
                var cur = Head;

                while(cur.Next!=null)
                {
                    cur = cur.Next;
                }

                cur.Next = new LinkedListNode(val, null, cur);
            }

            public void AddAtIndex(int index, int val)
            {
                var idx = 0;
                var node = new LinkedListNode(val, null, null);
                var cur = Head;
                LinkedListNode prev = null;
                while(idx < index && cur!=null)
                {
                    idx++;
                    prev = cur;
                    cur = cur.Next;
                }

                if (idx < index && cur == null)
                    return;
                else
                {
                    if(prev==null)
                    {
                        node.Next = cur;
                        if(cur!=null)
                            cur.Prev = node;
                        Head = node;
                    }
                    else
                    {
                        if(cur==null)
                        {
                            prev.Next = node;
                            node.Prev = prev;
                        }
                        else
                        {
                            node.Next = cur;
                            cur.Prev = node;
                            prev.Next = node;
                            node.Prev = prev;

                        }
                   
                    }

                }

            }

            public void DeleteAtIndex(int index)
            {
                var idx = 0;
                var cur=Head;
                LinkedListNode prev = null;
                while(idx < index && cur!=null)
                {
                    idx++;
                    prev = cur;
                    cur = cur.Next;
                }

                if (idx <= index && cur == null)
                    return;
                else
                {
                    if(prev==null)
                    {
                        Head = cur.Next;
                    }
                    else
                    {
                        prev.Next = cur.Next;
                        cur.Next = null;
                        cur.Prev = null;
                    }
                }

            }
        }
}
