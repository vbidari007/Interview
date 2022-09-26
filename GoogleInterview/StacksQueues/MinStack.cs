using System;
using System.Collections.Generic;

namespace StacksQueues
{
    public class MinStack
    {
        Stack<int[]> data;
        //int top = -1;
        public MinStack()
        {
            data = new Stack<int[]>();
            
        }

        public void Push(int val)
        {
            int[] min =new int[] { int.MaxValue, int.MaxValue };
            var res = data.TryPeek(out min);
            if(!res)
                min = new int[] { int.MaxValue, int.MaxValue }; 
            data.Push(new int[] { val, Math.Min(val, min[1]) });
        }

        public void Pop()
        {
            data.Pop();
        }

        public int Top()
        {
            return data.Peek()[0];
        }

        public int GetMin()
        {
            return data.Peek()[1];
        }
    }
}
