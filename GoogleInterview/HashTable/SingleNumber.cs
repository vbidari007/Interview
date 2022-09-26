using System;
using System.Collections.Generic;

namespace HashTable
{
    public class SingleNumber
    {
        public int SingleNumber_1(int[] nums)
        {
            var no_duplicates_list = new List<int>();

            foreach (var item in nums)
            {
                if(no_duplicates_list.Contains(item))
                {
                    no_duplicates_list.Remove(item);
                }
                else
                {
                    no_duplicates_list.Add(item);
                }
            }

            return no_duplicates_list[0];
        }

        public int Single_Number_2(int[] nums)
        {
            var hashtable = new Dictionary<int, int>();

            foreach (var item in nums)
            {
                if (hashtable.ContainsKey(item))
                    hashtable[item]++;
                else
                    hashtable.Add(item, 0);
            }

            foreach (var item in nums)
            {
                if (hashtable[item] == 1)
                    return item;
            }

            return 0;
        }

        public int Single_Number_3(int[] nums)
        {
            int sumofset = 0, sumofnum = 0;
            var set = new HashSet<int>();

            foreach (var item in nums)
            {
                if(!set.Contains(item))
                {
                    set.Add(item);
                    sumofset += item;
                }
                sumofnum += item;
            }

            return 2 * sumofset - sumofnum;
        }

        public int Single_Number_4(int[] nums)
        {
            int a = 0;
            foreach (var item in nums)
            {
                a  ^= item;
            }

            return a;
        }
    }
}
