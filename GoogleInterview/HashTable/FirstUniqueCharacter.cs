using System;
using System.Collections.Generic;

namespace HashTable
{
    public class FirstUniqueCharacter
    {
        public int FirstUniqChar(string s)
        {
            var dic = new Dictionary<char, int>();

            foreach (var ch in s)
            {
                if (dic.ContainsKey(ch))
                    dic[ch]++;
                else
                    dic.Add(ch, 1);
            }

            foreach (var item in dic)
            {
                if (item.Value == 1)
                    return s.IndexOf(item.Key);
            }

            return -1;
        }
    }
}
