using System;
using System.Collections.Generic;

namespace HashTable
{
    public class TwoSum
    {
        public int[] TwoSumMethod(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(dic.ContainsKey(nums[i]))
                {
                    return new int[] { dic[nums[i]], i };
                }
                else
                {
                    dic.Add(target - nums[i], i);
                }
            }

            return new int[] { };
        }
    }
}
