using System;
using System.Collections.Generic;

namespace StacksQueues
{
    public class MovingAverage
    {
        public double Average { get; set; }
        public Queue<int> data { get; set; }
        public int Size { get; set; }
        public int Sum { get; set; }
        public MovingAverage(int size)
        {
            data = new Queue<int>(size);
            Average = 0;
            Size = size;
            Sum = 0;
        }

        public double Next(int val)
        {
            if(data.Count==Size)
            {
                int item=data.Dequeue();
                Sum = Sum - item;
               
            }
            
                data.Enqueue(val);
                Sum = Sum + val;
           

            return  (double)(Sum / data.Count);
        }
    }
}
