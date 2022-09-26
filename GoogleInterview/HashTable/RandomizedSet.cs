using System;
using System.Collections.Generic;
using System.Linq;

namespace HashTable
{
    public class RandomizedSet
    {
        Dictionary<int, int> map;
        List<int> list;
        Random RND= new Random();
        public RandomizedSet()
        {
            map = new Dictionary<int, int>();
            list = new List<int>();
            //RND = 

        }

        public bool Insert(int val)
        {
            if(map.ContainsKey(val))
            {
                return false;
            }
            else
            {
                list.Add(val);
                map.Add(val, list.Count - 1);
                return true;
            }

        }

        public bool Remove(int val)
        {
            if (map.ContainsKey(val))
            {
                //var idx = map[val];
                var last = list[list.Count - 1];
                var idx = map[val];
                list.Insert(idx, last);
                map[last] = idx;
                list.RemoveAt(list.Count - 1);
                //list.Remove(val);
                map.Remove(val);

                return true;
            }
            else
                return false;
        }

        public int GetRandom()
        {
            return list[RND.Next(list.Count)];
        }
    }
}
