using System;
using System.Collections.Generic;

namespace HashTable
{
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            var dic = new HashSet<char>();
            var result = 0;
            foreach (var c in jewels)
            {
                dic.Add(c);
            }

            foreach (var c in stones)
            {
                if (dic.Contains(c))
                    result++;
            }

            return result;
        }
    }
}
