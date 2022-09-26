using System;
using System.Collections.Generic;

namespace HashTable
{
    public class _Sum
    {
        public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            int cnt = 0;
            var dic = new Dictionary<int, int>();

            foreach (var x in nums1)
            {
                foreach (var y in nums2)
                {
                    if (dic.ContainsKey((x + y)))
                        dic[x + y]++;
                    else
                        dic.Add((x + y), 1);
                }
            }


            foreach (var i in nums3)
            {
                foreach (var j in nums4)
                {
                    if (dic.ContainsKey(-1 * (i + j)))
                        cnt += dic[-1 * (i + j)];
                }
            }

            return cnt;
        }
    }
}
