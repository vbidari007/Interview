using System;
using System.Collections.Generic;

namespace HashTable
{
    public class Intersection
    {
        public int[] IntersectionMethod(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            foreach (var item in nums1)
            {
                set1.Add(item);
            }

            foreach (var item in nums2)
            {
                set2.Add(item);
            }

            if (set1.Count < set2.Count)
                return Set_Intersection(set1, set2);
            else
                return Set_Intersection(set2, set1);
        }

        public int[] Set_Intersection(HashSet<int> set1,HashSet<int> set2)
        {
            int[] output = new int[set1.Count];

            int idx = 0;

            foreach (var item in set1)
            {
                if(set2.Contains(item))
                {
                    output[idx++] = item;
                }
            }

            return output;
        }

        public int[]  IntersectionMethod2(int[] nums1,int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            foreach (var item in nums1)
            {
                set1.Add(item);
            }

            foreach (var item in nums2)
            {
                set2.Add(item);
            }

            set1.IntersectWith(set2);
            int[] output = new int[set1.Count];

            set1.CopyTo(output);

            return output;
        }
    }
}
