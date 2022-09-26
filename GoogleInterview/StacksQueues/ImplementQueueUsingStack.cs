using System;
using System.Collections.Generic;

namespace StacksQueues
{
    public class MyQueue
    {
        Stack<int> s1;
        Stack<int> s2;
        private int front;

        public MyQueue()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
        }

        public void Push(int x)
        {
            if (s1.Count == 0)
                front = x;
            while(s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }

            s2.Push(x);
            while(s2.Count > 0)
            {
                s1.Push(s2.Pop());
            }
        }

        public int Pop()
        {
            int res = s1.Pop();
            if(s1.Count > 0)
            {
                front = s1.Peek();
            }
            return res;
        }

        public int Peek()
        {
            return front;
        }

        public bool Empty()
        {
            return s1.Count == 0;
        }
    }
}
