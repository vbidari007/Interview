using System;
using System.Collections.Generic;

namespace HashTable
{
    public class ValidWordAbbr
    {
        string[] dic = null;
        Dictionary<string, HashSet<string>> map;
        public ValidWordAbbr(string[] dictionary)
        {
            dic = dictionary;
            map = new Dictionary<string, HashSet<string>>();
            foreach (var str in dictionary)
            {
                var abbr = Helper(str);
                if (map.ContainsKey(abbr))
                {
                    if(!map[abbr].Contains(str))
                        map[abbr].Add(str);

                }
                else
                    map.Add(Helper(str), new HashSet<string>() { str });
            }
        }

        private string Helper(string str)
        {
            if (str.Length > 2)
            {
                var len = str.Length - 2;
                var abbr = string.Format($"{str[0].ToString() + len + str[len + 1].ToString()}");
                return abbr;
               }
            return str;
        }
        public bool IsUnique(string word)
        {
            var abbr = Helper(word);

            if (!map.ContainsKey(abbr))
            {
                return true;
            }
            else
            {
                return map[abbr].Contains(word) && map[abbr].Count <= 1;
            }
        }
    }
}
