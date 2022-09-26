using System;
using System.Collections.Generic;

namespace HashTable
{
    public class TwoSum_2
    {
        HashSet<int> list1 = null;
        HashSet<int> list2 = null;
        public TwoSum_2()
        {
            list1 = new HashSet<int>();
            list2 = new HashSet<int>();
        }

      

        public void Add(int number)
        {
            foreach (var num in list1)
            {
                list2.Add(num + number);
            }
           if(! list1.Contains(number))
                list1.Add(number);

            
        }

        public bool Find(int value)
        {
            if(list2.Contains(value))
            {
                return true;
            }
            return false;
        }
    }
}
