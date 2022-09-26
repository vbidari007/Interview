using System;
using System.Collections.Generic;

namespace HashTable
{
    public class TopKfrequent
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var dic = new Dictionary<int, int>();
            var res = new int[k];

            foreach (var num in nums)
            {
                if (dic.ContainsKey(num))
                    dic[num]++;
                else
                    dic.Add(num, 1);

                
            }


            List<int>[] buckets = new List<int>[nums.Length + 1];

            for (int i = 0; i < nums.Length+2; i++)
            {
                buckets[i] = new List<int>();
            }

            foreach (var item in dic)
            {
                buckets[item.Value].Add(item.Key);
            }

            int x = 0;
            for (int i = buckets.Length; i >= 0 && x <k; i--)
            {
                foreach (var item in buckets[i])
                {
                    if(x<k)
                    {
                        res[x] = item;
                        x++;
                    }
                    else
                    {
                        break;
                    }
                   
                }
            }
            return res;

            

           

        }
    }
}
