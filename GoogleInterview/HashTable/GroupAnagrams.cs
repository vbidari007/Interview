using System;
using System.Collections.Generic;

namespace HashTable
{
    public class GroupAnagrams
    {
        public IList<IList<string>> GroupAnagramsMethod(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();
            var dic = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                var temp2 = str.ToCharArray();
                Array.Sort(temp2);
                var temp = new string(temp2);
                if(dic.ContainsKey(temp))
                {
                    dic[temp].Add(str);
                }
                else
                {
                    dic.Add(temp, new List<string>() { temp });
                }
            }

            foreach (var item in dic)
            {
                result.Add(item.Value);
            }

            return result;
        }
    }
}
