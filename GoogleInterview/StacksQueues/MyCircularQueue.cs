using System;
namespace StacksQueues
{
    public class MyCircularQueue
    {
        int[] data;
        int head = 0;
           // ,tail=0;
        int Size = -1;
        int Count = 0;


        public MyCircularQueue(int k)
        {
            data = new int[k];
            Size = k;
            for (int i = 0; i < k; i++)
            {
                data[i] = -1;
            }
        }

        public bool EnQueue(int value)
        {
            if (IsFull())
                return false;
            data[(head + Count) % Size] = value;
            Count++;
            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty())
                return false;

            //data[head] = -1;
            head = (head + 1) % Size;
            Count--;
            return true;

        }

        public int Front()
        {
            if (IsEmpty())
                return -1;
            return data[head];
        }

        public int Rear()
        {
            if (IsEmpty())
                return -1;
            var tail = (head + Count - 1) % Size;
            return data[tail];
        }

        public bool IsEmpty()
        {
            return (Count == 0);
        }

        public bool IsFull()
        {
            return Count == Size;
        }
    }
}
