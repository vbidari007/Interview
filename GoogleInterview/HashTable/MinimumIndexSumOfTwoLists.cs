using System;
using System.Collections.Generic;

namespace HashTable
{
    public class MinimumIndexSumOfTwoLists
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            var minSum = int.MaxValue;
            var dict = new Dictionary<int, List<string>>();
            var dic = new Dictionary<string, int>();
           // int p = 0, q = 0;

            for (int i = 0; i < list1.Length; i++)
            {
                //if(!dic.ContainsKey(list1[i]))
                {
                    dic.Add(list1[i], i);
                }
            }


            for (int i = 0; i < list2.Length; i++)
            {
                //int x = 0,y = 0;
                if(dic.ContainsKey(list2[i]))
                {
                    //  x = dic[list2[i]];
                    // y = i;

                    if (dict.ContainsKey(dic[list2[i] ] + i))
                        dict[dic[list2[i] ] + i].Add(list2[i]);
                    else
                        dict.Add(dic[list2[i] ] + i, new List<string>() { list2[i] });

                    
                }
            }

            foreach (var item in dict.Keys)
            {
                minSum = Math.Min(item, minSum);
            }
            return dict[minSum].ToArray();
        }
    }
}
