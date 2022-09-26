using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Heap
{
    public class Node : IComparable<Node>
    {
        public int Frequency { get; set; }
        public string word { get; set; }

        public int CompareTo( Node other)
        {
           if(this.Frequency==other.Frequency)
            {
                return string.Compare(this.word, other.word);
            }
            return other.Frequency - this.Frequency;
        }
    }

    public class MyHeapClass
    {
        List<Node> data = new List<Node>();


        public void Add(Node node)
        {
            int index = data.Count;

            data.Insert(index, node);
            HeapifyUp();
        }

       public void HeapifyUp()
        {
            var index = data.Count - 1;

            if (index > 0)
            {
                var parentIndex = GetParentIndex(index);

                while (index >= 0 && data[index].CompareTo(data[parentIndex]) < 0)
                {
                    
                    Swap(index, parentIndex);
                    index = parentIndex;
                    parentIndex = GetParentIndex(index);
                }
            }


        }


        public string Delete()
        {
            var size = data.Count;
            HeapifyDown();
            var res = data[size - 1];
            data.RemoveAt(size - 1);
            return res.word;
        }

        public void HeapifyDown()
        {
            int lastItemIndex = data.Count-1;
            int index = 0;
            Swap(index, lastItemIndex);
          //  lastItemIndex = lastItemIndex - 1;
            int leftIndex = GetLeftChildIndex(index);
            int rightIndex = GetRightChildIndex(index);

            while (leftIndex < lastItemIndex && rightIndex < lastItemIndex)
            {
                if (data[leftIndex].CompareTo( data[rightIndex]) < 0)
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
            if (leftIndex < lastItemIndex)
            {
                Swap(leftIndex, index);
                index = leftIndex;
            }
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


    }
    public class TopKFrequentWords
    {
        // words = ["i","love","leetcode","i","love","coding"], k = 2
        // Could you solve it in O(n log(k)) time and O(n) extra space?
        public IList<string> TopKFrequent(string[] words, int k)
        {
            int n = words.Length;
            IList<string> res = new List<string>();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            

            var heap = new MyHeapClass();

            foreach (var word in words)
            {
                if (dic.ContainsKey(word))
                    dic[word]++;
                else
                    dic.Add(word, 1);
            }

            foreach (var wordFreq in dic)
            {
                heap.Add(new Node() { Frequency=wordFreq.Value,word=wordFreq.Key});
            }

            for (int i = 0; i < k; i++)
            {
                res.Add(heap.Delete());
            }

            return res;

        }

       
    }
}
