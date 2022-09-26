using System;
using System.Collections.Generic;

namespace HashTable
{
    
  
 
    public class Duplicate2
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(dic.ContainsKey(nums[i]))
                {
                    if (Math.Abs(dic[nums[i]] - i) <= k)
                        return true;

                    dic[nums[i]] = i;

                }
                else
                {
                    dic.Add(nums[i], i);
                }
            }

            return false;
        }
    }
}
