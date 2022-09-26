using System;
using System.Collections.Generic;

namespace HashTable
{
    public class IntersectionOfTwoArrays
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var dic1 = new Dictionary<int, int>();
            var dic2 = new Dictionary<int, int>();
            var result = new List<int>();
            foreach (var num in nums1)
            {
                if (dic1.ContainsKey(num))
                    dic1[num]++;
                else
                    dic1.Add(num, 1);
            }
            foreach (var num in nums2)
            {
                if (dic2.ContainsKey(num))
                    dic2[num]++;
                else
                    dic2.Add(num, 1);
            }

            foreach (var item in dic1)
            {
                if(dic2.ContainsKey(item.Key))
                {
                    for (int i = 0; i < Math.Min(dic1[item.Key],dic2[item.Key]); i++)
                    {
                        result.Add(item.Key);
                    }
                }
            }

            return result.ToArray();
        }
    }
}
