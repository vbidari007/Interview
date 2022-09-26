using System;
using System.Collections.Generic;

namespace Heap
{
    public class MyHeap
    {
        List<int> data = new List<int>();

        public void Add(int val)
        {

            data.Add(val);
            HeapifyUp();
        }

        public void Delete(int val)
        {
            var size = data.Count;
            HeapifyDown(val);
            data.RemoveAt(size - 1);
        }

        public void PrintMin()
        {

            Console.WriteLine(data[0]);
        }

        public void Swap(int index1, int index2)
        {
            var temp = data[index1];
            data[index1] = data[index2];
            data[index2] = temp;
        }

        public int GetParentIndex(int index)
        {
            decimal res = (index - 1) / 2;
            return (int)Math.Floor(res);
        }

        public int GetLeftChildIndex(int index)
        {
            int res = (2 * index) + 1;

            return res;

        }

        public int GetRightChildIndex(int index)
        {
            int res = (2 * index) + 2;

            return res;

        }

        public void HeapifyUp()
        {
            var index = data.Count - 1;

            if (index > 0)
            {
                var parentIndex = GetParentIndex(index);

                while (index >= 0 && data[parentIndex] > data[index])
                {
                    Swap(index, parentIndex);
                    index = parentIndex;
                    parentIndex = GetParentIndex(index);
                }
            }



        }

        public void HeapifyDown(int val)
        {
            int deleteIndex = data.IndexOf(val);

            int lastItemIndex = data.Count - 1;
            Swap(lastItemIndex, deleteIndex);
            var index = deleteIndex;
            int leftIndex = GetLeftChildIndex(index);
            int rightIndex = GetRightChildIndex(index);

            while (leftIndex < lastItemIndex && rightIndex < lastItemIndex)
            {
                if (data[leftIndex] < data[rightIndex])
                {
                    Swap(leftIndex, index);
                    index = leftIndex;
                }
                else
                {
                    Swap(rightIndex, index);
                    index = rightIndex;
                }

                leftIndex = GetLeftChildIndex(index);
                rightIndex = GetRightChildIndex(index);
            }


        }

    }
}
