using System;
using System.Collections.Generic;

namespace StacksQueues
{
    public class MyStack
    {

        Queue<int> q1;
        Queue<int> q2;
        private int top;
        public MyStack()
        {
            q1 = new Queue<int>();
            q2 = new Queue<int>();
        }

        public void Push(int x)
        {
           // if (q1.Count == 0)
             top = x;
            q1.Enqueue(x);
        }

        public int Pop()
        {
           while(q1.Count > 0)
            {
                q2.Enqueue(q1.Dequeue());
            }
            int res = q2.Dequeue();
            q2.TryPeek(out top);
            while(q2.Count > 0)
            {
                q1.Enqueue(q2.Dequeue());
            }

            return res;
        }

        public int Top()
        {
            return top;
        }

        public bool Empty()
        {
            return q1.Count == 0;
        }
    }
}
